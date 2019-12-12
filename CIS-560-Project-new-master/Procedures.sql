--Insert and Update (TBD) Procedures
--Inserts a row into the Class table
CREATE OR ALTER PROCEDURE Homebrew.InsertClass
	@ClassId			INT					OUTPUT,
	@Name				NVARCHAR(32),
	@Description		NVARCHAR(256),
	@AttackMod			INT,
	@DefenseMod			INT
AS
	INSERT INTO Class(Name, Description, AttackMod, DefenseMod)
	VALUES(@Name, @Description, @AttackMod, @DefenseMod)

	SET @ClassId = SCOPE_IDENTITY()
GO

--Inserts a row into the Race table
CREATE OR ALTER PROCEDURE Homebrew.InsertRace
	@RaceId			INT					OUTPUT,
	@Name				NVARCHAR(32),
	@Description		NVARCHAR(256),
	@AttackMod			INT,
	@DefenseMod			INT
AS
	INSERT INTO Race(Name, Description, AttackMod, DefenseMod)
	VALUES(@Name, @Description, @AttackMod, @DefenseMod)

	SET @RaceId = SCOPE_IDENTITY()
GO

--Inserts a row into the Skill table
CREATE OR ALTER PROCEDURE Homebrew.InsertSkill
	@SkillId			INT					OUTPUT,
	@Name				NVARCHAR(32),
	@Description		NVARCHAR(256),
	@LevelRequirement	INT
AS
	INSERT INTO Skill(Name, Description, LevelRequirement)
	VALUES(@Name, @Description, @LevelRequirement)

	SET @SkillId = SCOPE_IDENTITY()
GO

--Inserts a row into the ClassSkill or ClassRace table depending on the value of @SkillOrigin
CREATE OR ALTER PROCEDURE Homebrew.AttachSkill
	@SkillId		INT					OUTPUT,
	@OtherId		INT,
	@SkillOrigin	NVARCHAR(16)  --Either 'Race' or 'Skill', depending in which table you would like to attach the skill to
AS
	IF(@SkillOrigin = N'Class')
	BEGIN
		INSERT INTO ClassSkill(ClassId, SkillId)
		VALUES(@OtherId, @SkillId)
	END
	ELSE IF(@SkillOrigin = N'Race')
	BEGIN
		INSERT INTO RaceSkill(RaceId, SkillId)
		VALUES(@OtherId, @SkillId)
	END
	ELSE THROW 50000, N'SkillOrigin should be either ''Race'' or ''Skill''', 1;
GO

--Inserts a row into the Weapon table
CREATE OR ALTER PROCEDURE Homebrew.InsertWeapon
	@WeaponId			INT					OUTPUT,
	@Name			NVARCHAR(32),
	@Description	NVARCHAR(256),
	@DamageTypeId	INT,
	@AttackMod		INT
AS
	INSERT INTO Weapon(Name, Description, DamageTypeId, AttackMod)
	VALUES(@Name, @Description, @DamageTypeId, @AttackMod)

	SET @WeaponId = SCOPE_IDENTITY()
GO

--Inserts a row into the Armour table
CREATE OR ALTER PROCEDURE Homebrew.InsertArmour
	@ArmourId			INT					OUTPUT,
	@Name				NVARCHAR(32),
	@Description		NVARCHAR(256),
	@ArmourTypeId		INT,
	@DamageTypeStrong	INT, 
	@DamageTypeWeak		INT,
	@DefenseMod			INT
AS
	INSERT INTO Armour(Name, Description, ArmourTypeId, DamageTypeStrong, DamageTypeWeak, DefenseMod)
	VALUES(@Name, @Description, @ArmourTypeId, @DamageTypeStrong, @DamageTypeWeak, @DefenseMod)

	SET @ArmourId = SCOPE_IDENTITY()
GO

--Retrieval Procedures (Question Queries)
--Retrieves all rows of the Class table
CREATE OR ALTER PROCEDURE List.GetAllClasses
AS
	SELECT *
	FROM Class C
	ORDER BY C.Name ASC
GO

--Retrieves all rows of the Race table
CREATE OR ALTER PROCEDURE List.GetAllRaces
AS
	SELECT *
	FROM Race R
	ORDER BY R.Name ASC
GO

--Retrieves all rows of the Weapon table
CREATE OR ALTER PROCEDURE List.GetAllWeapons
AS
	SELECT *
	FROM Weapon W
	ORDER BY W.Name ASC
GO

--Retrieves all rows of the Armour table
CREATE OR ALTER PROCEDURE List.GetAllArmour
AS
	SELECT *
	FROM Armour A
	ORDER BY A.Name ASC
GO

--Retrieves all rows of the Skill table
CREATE OR ALTER PROCEDURE List.GetAllSkills
AS
	SELECT * 
	FROM Skill S
	ORDER BY S.Name ASC
GO

--Retrieves all rows of the DamageType table
CREATE OR ALTER PROCEDURE List.GetAllDamageTypes
AS
	SELECT * 
	FROM DamageType DT
	ORDER BY DT.Name ASC
GO

--Retrieves all rows of the ArmourType table
CREATE OR ALTER PROCEDURE List.GetAllArmourTypes
AS
	SELECT * 
	FROM ArmourType AT
	ORDER BY AT.Name ASC
GO

--Gets the Skills associated with a certain Class
CREATE OR ALTER PROCEDURE Player.GetClassAttachedSkill
	@ClassId	INT
AS
	SELECT S.*
	FROM Class C INNER JOIN ClassSkill CS ON C.ClassId = CS.ClassId
		INNER JOIN Skill S ON S.SkillId = CS.SkillId
	WHERE C.ClassId = @ClassId
	GROUP BY S.SkillId, S.Name, S.Description, S.LevelRequirement
	ORDER BY S.LevelRequirement ASC
GO

--Gets the Skills associated with a certain Race
CREATE OR ALTER PROCEDURE Player.GetRaceAttachedSkill
	@RaceId	INT
AS
	SELECT S.*
	FROM Race R INNER JOIN RaceSkill RS ON R.RaceId = RS.RaceId
		INNER JOIN Skill S ON S.SkillId = RS.SkillId
	WHERE R.RaceId = @RaceId
	GROUP BY S.SkillId, S.Name, S.Description, S.LevelRequirement
	ORDER BY S.LevelRequirement ASC
GO

--Extensive details
--Gets a row with the inputted Id in Class
CREATE OR ALTER PROCEDURE Player.GetClass
	@ClassId	INT
AS
	SELECT *
	FROM Details.GetClass(@ClassId)
GO

--Gets a row with the inputted Id in Race
CREATE OR ALTER PROCEDURE Player.GetRace
	@RaceId		INT
AS
	SELECT *
	FROM Details.GetRace(@RaceId)
GO

--Gets a row with the inputted Id in Skill
CREATE OR ALTER PROCEDURE Player.GetSkill
	@SkillId	INT
AS
	SELECT *
	FROM Details.GetSkill(@SkillId)
GO

--Gets a row with the inputted Id in Weapon
CREATE OR ALTER PROCEDURE Player.GetWeapon
	@WeaponId	INT
AS
	SELECT *
	FROM Details.GetWeapon(@WeaponId)
GO

--Gets a row with the inputted Id in Armour
CREATE OR ALTER PROCEDURE Player.GetArmour
	@ArmourId	INT
AS
	SELECT *
	FROM Details.GetArmour(@ArmourId)
GO

--Gets a row with the inputted Id in DamageType
CREATE OR ALTER PROCEDURE Player.GetDamageType
	@DamageTypeId	INT
AS
	SELECT *
	FROM Details.GetDamageType(@DamageTypeId)
GO

--Gets a row with the inputted Id in ArmourType
CREATE OR ALTER PROCEDURE Player.GetArmourType
	@ArmourTypeId	INT
AS
	SELECT *
	FROM Details.GetArmourType(@ArmourTypeId)
GO

--Retrieval Queries (Report Queries)
/*
Gets all the skills that are associated with the inputted class and race, and whose level requirement are lower than @level
	Includes all of the columns of Skill
	Additional columns:
		Source:				A string denoting whether or not it is attached to Class or Race, it is instead '2 Sources' when the skill is attached to both
*/
CREATE OR ALTER PROCEDURE Player.GetAvailableSkills
	@ClassId	INT,
	@RaceId		INT,
	@Level		INT
AS	
	SELECT S.SkillId, S.Name, S.Description, S.LevelRequirement, CASE
		WHEN COUNT(S.SkillId) > 1 THEN CONCAT(COUNT(S.SkillId), ' Sources')
		ELSE MIN(S.Source) --There is only one Source, present that source
	END AS Source
	FROM
		(
			SELECT S.*, 'Class' AS Source
			FROM Class C 
				INNER JOIN ClassSkill CS ON C.ClassId = CS.ClassId
				INNER JOIN Skill S ON S.SkillId = CS.SkillId
			WHERE C.ClassId = @ClassId
		UNION ALL
			SELECT S.*, 'Race' AS Source
			FROM Race R 
				INNER JOIN RaceSkill RS ON R.RaceId = RS.RaceId
				INNER JOIN Skill S ON S.SkillId = RS.SkillId
			WHERE R.RaceId = @RaceId
		) AS S
	WHERE S.LevelRequirement <= @Level
	GROUP BY S.SkillId, S.Name, S.Description, S.LevelRequirement
	ORDER BY S.LevelRequirement ASC
GO

/*
Ranks all classes based on particular statistics
	Includes all of the columns of Class
	Additional columns:
		PowerLevel:		The sum of AttackMod and DefenseMod
		AttackRank:		A number denoting how high its AttackMod is in comparison to other class; 1 is the highest rank
		DefenseRank:	A number denoting how high its DefenseMod is in comparison to other class; 1 is the highest rank
		PowerRank:		A number denoting how high its PowerLevel is in comparison to other class; 1 is the highest rank
*/
CREATE OR ALTER PROCEDURE Player.GetOptimalClasses
AS
	SELECT 
		C.*, C.AttackMod + C.DefenseMod AS PowerLevel,
		RANK() OVER(ORDER BY C.AttackMod DESC, C.DefenseMod DESC) AS AttackRank,
		RANK() OVER(ORDER BY C.DefenseMod DESC, C.AttackMod DESC) AS DefenseRank,
		RANK() OVER(ORDER BY C.AttackMod + C.DefenseMod DESC) AS PowerRank
	FROM Class C
	GROUP BY C.ClassId, C.Name, C.Description, C.AttackMod, C.DefenseMod
	ORDER BY C.Name ASC
GO

/*
Gets statistics for each DamageType
	Includes all of the columns of DamageType
	Additional columns:
		NumWeapons:					The number of weapons that deal this damage type
		AverageDamage:				The average damage of the weapons that deal this damage type
		HighestDamage:				The highest damage of the weapons that deal this damage type
		StrongestWeaponLowestId:	An Id of the weapon that deals the most damage and deals this damage type
		NumStrongArmour:			The number of armours that are strong against this damage type
		AverageDefenseStrongArmour:	The average DefenseMod of armours that are strong against this damage type
		StrongestArmourDefenseMod:	An Id of an armour that is strong against this damage type
		NumWeakArmour:				The number of armours that are weak against this damage type
		AverageDefenseWeakArmour:	The average DefenseMod of armours that are weak against this damage type
*/
CREATE OR ALTER PROCEDURE Player.GetDamageTypeStats
AS
	SELECT DT.*, 
		COUNT(DISTINCT W.WeaponId) AS NumWeapons,
		AVG(DISTINCT W.AttackMod) AS AverageDamage,
		MAX(W.AttackMod) AS HighestDamage,
		(
			SELECT MIN(WS.WeaponId)
			FROM Weapon WS
			WHERE WS.AttackMod = MAX(W.AttackMod)
		) AS StrongestWeaponLowestId,
		COUNT(DISTINCT AStr.ArmourId) AS NumStrongArmour,
		AVG(DISTINCT AStr.DefenseMod) AS AverageDefenseStrongArmour,
		MAX(AStr.DefenseMod) AS StrongestArmourDefenseMod,
		(
			SELECT MIN(A.ArmourId)
			FROM Armour A
			WHERE A.DefenseMod = MAX(AStr.DefenseMod)
		) AS StrongestArmourLowestId,
		COUNT(DISTINCT AWk.ArmourId) AS NumWeakArmour,
		AVG(DISTINCT AWk.DefenseMod) AS AverageDefenseWeakArmour
	FROM DamageType DT 
		INNER JOIN Weapon W ON DT.DamageTypeId = W.DamageTypeId
		INNER JOIN Armour AStr ON DT.DamageTypeId = AStr.DamageTypeStrong
		INNER JOIN Armour AWk ON DT.DamageTypeId = AWk.DamageTypeWeak
	GROUP BY DT.DamageTypeId, DT.Name, DT.Acronym
	ORDER BY DT.Name ASC
GO

/*
Gets the races and classes that are associated with a certain skill and gets statistics on the race or class
	Includes all of the columns of Skill
	Additional columns:
		Source:						A string denoting whether the skill is attached to a race or class
		SourceId:					The Id of the race or class that the skill is associated with
		AttackMod:					The AttackMod of the race or class the skill is associated with
		DefenseMod:					The DefenseMod of the race or class the skill is associated with
		PowerLevel:					The sum of AttackMod and DefenseMod of the race or class the skill is associated with
*/
CREATE OR ALTER PROCEDURE Player.FromSkillGetNonDuplicatedClassOrRace
	@SkillId	INT
AS
	SELECT *, 
		RANK() OVER(ORDER BY S.AttackMod DESC, S.DefenseMod DESC) AS AttackRank,
		RANK() OVER(ORDER BY S.DefenseMod DESC, S.AttackMod DESC) AS DefenseRank,
		RANK() OVER(ORDER BY S.PowerLevel DESC) AS PowerRank
	FROM 
	(
		(--Gets all combinations of class and race
			SELECT S.SkillId, S.Name, S.Description, S.LevelRequirement, 'Class' AS Source, CS.ClassId AS SourceId, C.AttackMod, C.DefenseMod, C.AttackMod + C.DefenseMod AS PowerLevel
			FROM Skill S 
				INNER JOIN ClassSkill CS ON S.SkillId = CS.SkillId
				INNER JOIN Class C ON C.ClassId = CS.ClassId
			GROUP BY S.SkillId, S.Name, S.Description, S.LevelRequirement, CS.ClassId, C.AttackMod, C.DefenseMod
		)
	UNION
		(
			SELECT S.SkillId, S.Name, S.Description, S.LevelRequirement, 'Race' AS Source, RS.RaceId AS SourceId, R.AttackMod, R.DefenseMod, R.AttackMod + R.DefenseMod AS PowerLevel
			FROM Skill S 
				INNER JOIN RaceSkill RS ON S.SkillId = RS.SkillId
				INNER JOIN Race R ON R.RaceId = RS.RaceId
			GROUP BY S.SkillId, S.Name, S.Description, S.LevelRequirement, RS.RaceId, R.AttackMod, R.DefenseMod
		)
	) AS S
	WHERE S.SkillId = @SkillId
	ORDER BY Source ASC, PowerLevel DESC
GO
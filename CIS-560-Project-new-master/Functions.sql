--Functions for retrieving details
CREATE OR ALTER FUNCTION Details.GetClass (
	@ClassId AS INT
)
RETURNS TABLE
AS
RETURN
	SELECT C.Name, C.Description, C.AttackMod, C. DefenseMod
	FROM Class C
	WHERE C.ClassId = @ClassId
	GROUP BY C.Name, C.Description, C.AttackMod, C. DefenseMod
GO

CREATE OR ALTER FUNCTION Details.GetRace (
	@RaceId AS INT
)
RETURNS table
AS
RETURN
	SELECT R.Name, R.Description, R.AttackMod, R.DefenseMod
	FROM Race R
	WHERE R.RaceId = @RaceId
	GROUP BY R.Name, R.Description, R.AttackMod, R.DefenseMod
GO

CREATE OR ALTER FUNCTION Details.GetSkill (
	@SkillId AS INT
)
RETURNS table
AS
RETURN
	SELECT S.Name, S.Description, S.LevelRequirement
	FROM Skill S
	WHERE S.SkillId = @SkillId
	GROUP BY S.Name, S.Description, S.LevelRequirement
GO

CREATE OR ALTER FUNCTION Details.GetWeapon (
	@WeaponId AS INT
)
RETURNS TABLE
AS
RETURN
	SELECT W.Name, W.DamageTypeId, W.Description, W.AttackMod
	FROM Weapon W
	WHERE W.WeaponId = @WeaponId
	GROUP BY W.Name, W.DamageTypeId, W.Description, W.AttackMod
GO

CREATE OR ALTER FUNCTION Details.GetArmour (
	@ArmourId AS INT
)
RETURNS table
AS
RETURN
	SELECT A.Name, A.ArmourTypeId, A.DamageTypeStrong, A.DamageTypeWeak, A.Description, A.DefenseMod
	FROM Armour A
	WHERE A.ArmourId = @ArmourId
	GROUP BY A.Name, A.ArmourTypeId, A.DamageTypeStrong, A.DamageTypeWeak, A.Description, A.DefenseMod
GO

CREATE OR ALTER FUNCTION Details.GetDamageType (
	@DamageTypeId AS INT
)
RETURNS TABLE
AS
RETURN
	SELECT D.Name, D.Acronym
	FROM DamageType D
	WHERE D.DamageTypeId = @DamageTypeId
	GROUP BY D.Name, D.Acronym
GO

CREATE OR ALTER FUNCTION Details.GetArmourType (
	@ArmourTypeId AS INT
)
RETURNS TABLE
AS
RETURN
	SELECT A.Name
	FROM ArmourType A
	WHERE A.ArmourTypeId = @ArmourTypeId
	GROUP BY A.Name
GO
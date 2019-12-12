DROP TABLE IF EXISTS ClassSkill;
DROP TABLE IF EXISTS RaceSkill;
DROP TABLE IF EXISTS Class;
DROP TABLE IF EXISTS Skill;
DROP TABLE IF EXISTS Race;

DROP TABLE IF EXISTS Weapon;
DROP TABLE IF EXISTS Armour;
DROP TABLE IF EXISTS DamageType;
DROP TABLE IF EXISTS ArmourType;

CREATE TABLE Class
(
	ClassId				INT				NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
	Name				NVARCHAR(128)	NOT NULL					UNIQUE,
	Description			NVARCHAR(2048)	NOT NULL,
	AttackMod			INT				NOT NULL	DEFAULT(0),
	DefenseMod			INT				NOT NULL	DEFAULT(0),

	CHECK(AttackMod >= 0),
	CHECK(DefenseMod >= 0)
);

CREATE TABLE Race
(
	RaceId				INT				NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
	Name				NVARCHAR(128)	NOT NULL					UNIQUE,
	Description			NVARCHAR(2048)	NOT NULL,
	AttackMod			INT				NOT NULL	DEFAULT(0),
	DefenseMod			INT				NOT NULL	DEFAULT(0),

	CHECK(AttackMod >= 0),
	CHECK(DefenseMod >= 0)
);

CREATE TABLE Skill
(
	SkillId				INT				NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
	Name				NVARCHAR(128)	NOT NULL					UNIQUE,
	Description			NVARCHAR(2048)	NOT NULL,
	LevelRequirement	INT				NOT NULL	DEFAULT(1),

	CHECK(LevelRequirement >= 1)
);

CREATE TABLE ClassSkill
(
	ClassId				INT				NOT NULL,
	SkillId				INT				NOT NULL,
	
	PRIMARY KEY(ClassId, SkillId),
	FOREIGN KEY(ClassId) REFERENCES Class(ClassId),
	FOREIGN KEY(SkillId) REFERENCES Skill(SkillId)
);

CREATE TABLE RaceSkill
(
	RaceId				INT				NOT NULL,
	SkillId				INT				NOT NULL,
	
	PRIMARY KEY(RaceId, SkillId),
	FOREIGN KEY(RaceId) REFERENCES Race(RaceId),
	FOREIGN KEY(SkillId) REFERENCES Skill(SkillId)
);

CREATE TABLE DamageType
(
	DamageTypeId		INT				NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
	Name				NVARCHAR(32)	NOT NULL					UNIQUE,
	Acronym				NVARCHAR(8)		NOT NULL					UNIQUE
);

CREATE TABLE ArmourType
(
	ArmourTypeId		INT				NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
	Name				NVARCHAR(32)	NOT NULL					UNIQUE
);

CREATE TABLE Weapon
(
	WeaponId			INT				NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
	Name				NVARCHAR(128)	NOT NULL					UNIQUE,
	Description			NVARCHAR(2048)	NOT NULL,
	DamageTypeId		INT				NOT NULL,
	AttackMod			INT				NOT NULL	DEFAULT(1),

	FOREIGN KEY(DamageTypeId) REFERENCES DamageType(DamageTypeId),
	CHECK(AttackMod >= 0)
);

CREATE TABLE Armour
(
	ArmourId			INT				NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
	Name				NVARCHAR(128)	NOT NULL					UNIQUE,
	Description			NVARCHAR(2048)	NOT NULL,
	ArmourTypeId		INT				NOT NULL,
	DamageTypeStrong	INT				NOT NULL,
	DamageTypeWeak		INT				NOT NULL,
	DefenseMod			INT				NOT NULL	DEFAULT(1),

	FOREIGN KEY(ArmourTypeId) REFERENCES ArmourType(ArmourTypeId),
	FOREIGN KEY(DamageTypeStrong) REFERENCES DamageType(DamageTypeId),
	FOREIGN KEY(DamageTypeWeak) REFERENCES DamageType(DamageTypeId),
	CHECK(DefenseMod >= 0),
	CHECK(NOT DamageTypeStrong = DamageTypeWeak)
);
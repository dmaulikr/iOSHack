//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using NUnit.Framework;
using System;
using System.Collections.Generic;
using AssemblyCSharp;

namespace Testing
{
	[TestFixture()]
	public class Character_Creation_Testing
	{
		[Test()]
		public void PermStatChange()
		{
			List<Race> races = new List<Race>();
			races.Add(new Race(RaceTypes.Human));
			
			List<CharClass> charClasses = new List<CharClass>();
			charClasses.Add(new CharClass(CharacterClass.Warrior));
			
			Character newChar = new Character("Test Dude", Sexes.Male, races, charClasses);

			List<AssemblyCSharp.Attribute> tempStats = new List<AssemblyCSharp.Attribute>();
			tempStats.Add(new AssemblyCSharp.Attribute(AttributeTypes.Strength, 10));
			tempStats.Add(new AssemblyCSharp.Attribute(AttributeTypes.Dexterity, 10));
			tempStats.Add(new AssemblyCSharp.Attribute(AttributeTypes.Constitution, 10));
			tempStats.Add(new AssemblyCSharp.Attribute(AttributeTypes.Intelligence, 10));
			tempStats.Add(new AssemblyCSharp.Attribute(AttributeTypes.Wisdom, 10));
			tempStats.Add(new AssemblyCSharp.Attribute(AttributeTypes.Charisma, 10));

			newChar.ChangeAttribute(tempStats, AttributeTypes.Strength, 1);

			Assert.AreEqual(tempStats[(int)AttributeTypes.Strength].AttributeLevel, 11);

			newChar.ChangeAttribute(tempStats, AttributeTypes.Dexterity, -1);
			
			Assert.AreEqual(tempStats[(int)AttributeTypes.Dexterity].AttributeLevel, 9);
		}

		// Race Testing
		[Test()]
		public void CreateHuman ()
		{
			List<Race> races = new List<Race>();
			races.Add(new Race(RaceTypes.Human));
			
			List<CharClass> charClasses = new List<CharClass>();
			charClasses.Add(new CharClass(CharacterClass.Warrior));
			
			Character newChar = new Character("Test Dude", Sexes.Male, races, charClasses);

			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Strength].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Dexterity].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Constitution].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Intelligence].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Wisdom].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Charisma].AttributeLevel);
		}

		[Test()]
		public void CreateElf ()
		{
			List<Race> races = new List<Race>();
			races.Add(new Race(RaceTypes.Elf));
			
			List<CharClass> charClasses = new List<CharClass>();
			charClasses.Add(new CharClass(CharacterClass.Warrior));
			
			Character newChar = new Character("Test Dude", Sexes.Male, races, charClasses);

			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Strength].AttributeLevel);
			Assert.AreEqual(12, newChar.baseAttributes[(int)AttributeTypes.Dexterity].AttributeLevel);
			Assert.AreEqual(8, newChar.baseAttributes[(int)AttributeTypes.Constitution].AttributeLevel);
			Assert.AreEqual(12, newChar.baseAttributes[(int)AttributeTypes.Intelligence].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Wisdom].AttributeLevel);
			Assert.AreEqual(11, newChar.baseAttributes[(int)AttributeTypes.Charisma].AttributeLevel);
		}

		
		[Test()]
		public void CreateHalfing()
		{
			List<Race> races = new List<Race>();
			races.Add(new Race(RaceTypes.Halfling));
			
			List<CharClass> charClasses = new List<CharClass>();
			charClasses.Add(new CharClass(CharacterClass.Warrior));
			
			Character newChar = new Character("Test Dude", Sexes.Male, races, charClasses);

			Assert.AreEqual(8, newChar.baseAttributes[(int)AttributeTypes.Strength].AttributeLevel);
			Assert.AreEqual(12, newChar.baseAttributes[(int)AttributeTypes.Dexterity].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Constitution].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Intelligence].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Wisdom].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Charisma].AttributeLevel);
		}
		
		[Test()]
		public void CreateGnome ()
		{
			List<Race> races = new List<Race>();
			races.Add(new Race(RaceTypes.Gnome));
			
			List<CharClass> charClasses = new List<CharClass>();
			charClasses.Add(new CharClass(CharacterClass.Warrior));
			
			Character newChar = new Character("Test Dude", Sexes.Male, races, charClasses);
			Assert.AreEqual(8, newChar.baseAttributes[(int)AttributeTypes.Strength].AttributeLevel);
			Assert.AreEqual(12, newChar.baseAttributes[(int)AttributeTypes.Dexterity].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Constitution].AttributeLevel);
			Assert.AreEqual(11, newChar.baseAttributes[(int)AttributeTypes.Intelligence].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Wisdom].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Charisma].AttributeLevel);
		}
		
		[Test()]
		public void CreateDwarf ()
		{
			List<Race> races = new List<Race>();
			races.Add(new Race(RaceTypes.Dwarf));

			List<CharClass> charClasses = new List<CharClass>();
			charClasses.Add(new CharClass(CharacterClass.Warrior));
			
			Character newChar = new Character("Test Dude", Sexes.Male, races, charClasses);

			Assert.AreEqual(12, newChar.baseAttributes[(int)AttributeTypes.Strength].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Dexterity].AttributeLevel);
			Assert.AreEqual(12, newChar.baseAttributes[(int)AttributeTypes.Constitution].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Intelligence].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Wisdom].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Charisma].AttributeLevel);
		}
		
		[Test()]
		public void CreateOrc ()
		{
			List<Race> races = new List<Race>();
			races.Add(new Race(RaceTypes.Orc));
			
			List<CharClass> charClasses = new List<CharClass>();
			charClasses.Add(new CharClass(CharacterClass.Warrior));
			
			Character newChar = new Character("Test Dude", Sexes.Male, races, charClasses);

			Assert.AreEqual(12, newChar.baseAttributes[(int)AttributeTypes.Strength].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Dexterity].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Constitution].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Intelligence].AttributeLevel);
			Assert.AreEqual(10, newChar.baseAttributes[(int)AttributeTypes.Wisdom].AttributeLevel);
			Assert.AreEqual(7, newChar.baseAttributes[(int)AttributeTypes.Charisma].AttributeLevel);
		}
	}
}


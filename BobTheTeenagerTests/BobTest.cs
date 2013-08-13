using BobTheTeenager;
using NUnit.Framework;

namespace BobTheTeenagerTests
{
	[TestFixture]
	public class TeenagerTest
	{
		private Bob _teenager;

		[SetUp]
		public void setup()
		{
			_teenager = new Bob();
		}

		[Test,Ignore]
		public void test_stating_something()
		{
			Assert.That(_teenager.hey("Tom-ay-to, tom-aaah-to."), Is.EqualTo("Whatever."));
		}

		[Test, Ignore]
		public void test_shouting()
		{
			Assert.That(_teenager.hey("WATCH OUT!"), Is.EqualTo("Whoa,chill out!"));
		}

		[Test, Ignore]
		public void test_asking_a_question()
		{
			Assert.That(_teenager.hey("Does this cryogenic chamber make me look fat?"), Is.EqualTo("Sure."));
		}

		[Test, Ignore]
		public void test_talking_forcefully()
		{
			Assert.That(_teenager.hey("Let's go make out behind the gym!"), Is.EqualTo("Whatever."));
		}

		[Test, Ignore]
		public void test_using_acronyms_in_regular_speech()
		{
			Assert.That(_teenager.hey("It's OK if you don't want to go to the DMV."), Is.EqualTo("Whatever."));
		}

		[Test, Ignore]
		public void test_forceful_questions()
		{
			Assert.That(_teenager.hey("WHAT THE HELL	WERE YOU THINKING?"), Is.EqualTo("Whoa,chill out!"));
		}

		[Test, Ignore]
		public void test_shouting_with_special_characters()
		{
			Assert.That(_teenager.hey("ZOMG THE %^*@#$(*^ ZOMBIES ARE COMING!!11!!1!"), Is.EqualTo("Whoa,chill out!"));
		}

		[Test, Ignore]
		public void test_shouting_with_no_exclamation_mark()
		{
			Assert.That(_teenager.hey("I HATE YOU"), Is.EqualTo("Whoa,chill out!"));
		}

		[Test, Ignore]
		public void test_statement_containing_question_mark()
		{
			Assert.That(_teenager.hey("Ending with ? means a question."), Is.EqualTo("Whatever."));
		}

		[Test, Ignore]
		public void test_prattling_on()
		{
			Assert.That(_teenager.hey("Wait! Hang on. Are you going to be OK?"), Is.EqualTo("Sure."));
		}

		[Test, Ignore]
		public void test_silence()
		{
			Assert.That(_teenager.hey(""),Is.EqualTo("Fine. Be that way!"));
		}

		[Test, Ignore]
		public void test_more_silence()
		{
			Assert.That(_teenager.hey(null), Is.EqualTo("Fine. Be that way!"));
		}
	}
}

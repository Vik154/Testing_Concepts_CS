﻿// https://learn.microsoft.com/ru-ru/visualstudio/test/live-unit-testing-start?view=vs-2022
using Projects;
namespace Tests;


[TestClass]
public class UnitTest1 {
    [TestMethod]
    public void TestStartsWithUpper() {
        // Tests that we expect to return true.
        string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
        foreach (var word in words) {
            bool result = word.StartsWithUpper();
            Assert.IsTrue(result,
                          $"Expected for '{word}': true; Actual: {result}");
        }
    }

    [TestMethod]
    public void TestDoesNotStartWithUpper() {
        // Tests that we expect to return false.
        string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " " };
        foreach (var word in words) {
            bool result = word.StartsWithUpper();
            Assert.IsFalse(result,
                           $"Expected for '{word}': false; Actual: {result}");
        }
    }

    [TestMethod]
    public void DirectCallWithNullOrEmpty() {
        // Tests that we expect to return false.
        string[] words = { String.Empty, null };
        foreach (var word in words) {
            bool result = StringLibraryMSDN.StartsWithUpper(word);
            Assert.IsFalse(result,
                           $"Expected for '{(word == null ? "<null>" : word)}': " +
                           $"false; Actual: {result}");
        }
    }

    [TestMethod]
    public void TestStartsWithLower() {
        // Tests that we expect to return true.
        string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство" };
        foreach (var word in words) {
            bool result = word.StartsWithLower();
            Assert.IsTrue(result,
                          $"Expected for '{word}': true; Actual: {result}");
        }
    }

    [TestMethod]
    public void TestDoesNotStartWithLower() {
        // Tests that we expect to return false.
        string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва",
                       "1234", ".", ";", " "};
        foreach (var word in words) {
            bool result = word.StartsWithLower();
            Assert.IsFalse(result,
                           $"Expected for '{word}': false; Actual: {result}");
        }
    }
}
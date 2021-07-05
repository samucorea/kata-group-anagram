module AnagramCheck.Tests

open NUnit.Framework
open Anagram

[<SetUp>]
let Setup () = ()

[<Test>]
let AnagramCheckWhenInputIsEmptyStringArray () =
    let expected = []
    let actual = Anagram.getAnagrams [||]

    Assert.AreEqual(expected, actual)

// [("moor", ["romo"; "moro"])];
[<Test>]
let AnagramCheckWillReturnListOfKeyValue () =
    let expected = [("moor", ["romo"; "moro"])];
    let actual = Anagram.getAnagrams [| "romo"; "moro"|]
    Assert.That(actual, Is.EqualTo(expected));


[<Test>]
let AnagramCheckIfThereIsNotAnagramsShouldReturnEmptyList () =
    let expected = [];
    let actual = Anagram.getAnagrams [| "hola"; "adios"|]
    Assert.That(actual, Is.EqualTo(expected));
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

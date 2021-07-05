namespace AnagramCheck
open System
module Anagram =
    let getAnagrams (words: string array) = 
        let getKey( str : string ) =
            str.ToCharArray()
            |> Array.sort
            |> String
        
        words
        |> Array.groupBy getKey
        |> Array.filter (fun (sortedWord, originalWord) -> originalWord.Length > 1)


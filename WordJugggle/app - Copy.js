'use strict';

console.log('Word Jugggle');

var wordToBeJuggled = "ABC";
WordJugggle(wordToBeJuggled);


/** 
    * permutation function 
    * @param str string to  
       calculate permutation for 
    * @param l starting index 
    * @param r end index 
    */
function WordJugggle(word)
{
    var left = 0;
    var right = word.length - 1;
    if (left == right)
        console.log(word);
    else {
        for (var i = l; i <= r; i++)
        {
            word = swap(word, left, i);
            console.log(word);
            WordJugggle(word, left + 1, right);
            word = swap(word, left, i);
            console.log(word);
        }
    }
}
    function Swap(word,i,j)
{
    var temp;
    temp = word[i];
    word[i] = word[j];
    word[j] = temp;
        var s = word;
    return s;
}



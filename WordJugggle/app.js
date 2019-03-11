console.log('Word Jugggle');

juggledLetter = [];
distinctJugglet = [];
var wordToBeJuggled = "JAVA";
finalDistinctJugglet = WordJugggle(wordToBeJuggled.split("").sort());
console.log("=== FINAL DISTINCT JUGGLET OUTPUT ===");
console.log(finalDistinctJugglet);
console.log("Press any key to exit");

function WordJugggle(word) {
    var availableLetter;

    for (var i = 0; i < word.length; i++) {
        availableLetter = word.splice(i, 1)[0];

        //add to the juggled letters list
        juggledLetter.push(availableLetter);

        //measure if word length has reached 0 then WordJugggleDistinct the juggled word
        if (word.length == 0) {
            var juggledWord = juggledLetter.join("");
            if (WordJugggleDistinct(juggledWord)) {
                distinctJugglet.push(juggledWord);
                console.log(distinctJugglet + " Distinctive Juggle List");
            }
        } else {
            //else keep jugglin on the remaining letters available
            WordJugggle(word);
        }
        word.splice(i, 0, availableLetter);

        //remove juggled already letters
        juggledLetter.pop();
    }

    return distinctJugglet;
}

function WordJugggleDistinct(juggledWord) {
    var isDistinct = true
    found = distinctJugglet.filter(x => x == juggledWord).length;
    if (found > 0)
        isDistinct = false;

    return isDistinct;
}


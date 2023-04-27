Algorithm: Sentence Analysis
Inputs: A sentence ending with a period (.)
Outputs: Length of the sentence, number of words, number of vowels

Variables:
len <- 0  // counter for sentence length
words <- 1 // counter for number of words (assuming at least one word)
vowels <- 0 // counter for number of vowels

LOOP
    character <- READ() // read one character
    IF character = "." THEN
        EXIT // end of sentence
    END IF
    len <- len + 1 // increment length counter
    IF character = " " THEN
        words <- words + 1 // increment word counter
    END IF
    IF character is a vowel THEN
        vowels <- vowels + 1 // increment vowel counter
    END IF
END LOOP

// output the results
WRITE "Length of the sentence is ", len
WRITE "Number of words is ", words
WRITE "Number of vowels is ", vowels

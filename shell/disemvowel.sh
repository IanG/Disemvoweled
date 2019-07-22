#!/bin/bash

if [[ $# -eq 1 ]]; then
    phrase=$1

    if [[ ${phrase} =~ ^[a-z\ ]*$ ]]; then
        echo ${phrase} | grep -o [^aeiou] | xargs | sed 's/ //g'
        echo ${phrase} | grep -o [aeiou] | xargs | sed 's/ //g'
        exit 0
    else
        echo "Phrase '${phrase}' contains invalid characters"
        exit 1
    fi
else
    echo "Usage:"
    echo -e "\t${0} \"<input>\""
    echo "Where:"
    echo -e "\t<input> - string of words to disemvowel in all lowercase (letters a-z) and without punctuation but including spaces."
    exit 1
fi

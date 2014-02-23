## Description
Console application which translates a single word from source language to destination language. Translation is based on [MyMemory translation API](http://mymemory.translated.net/doc/spec.php)

## Usage
    > WordTranslator.exe --word <word> --inputLanguage <language> --outputLanguage <language>
To print out help, use the `--help` switch.
```
> WordTranslator.exe --help
Program that translates input word from input language to output language.

Usage: WordTranslator.exe --word --inputLanugage --outputLanguage

--word <input_word>           Word that will be translated.
--inputLanguage <language>    Specify the input word language in standard RFC3066 format. Default 'en'
--outputLanguage <language>   Specify desired output language in standard RFC3066 format. Default 'sr'
--help                        This text
```
	
## Example
To translate word 'thanks' from English to French, use the WordTranslator like this
```    
> WordTranslator.exe --word thanks --inputLanguage en --outputLanguage fr 
Merci
```

## License
MIT
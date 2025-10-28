# BasicTranslator
A skill check program built in C#. Translates English words into Spanish or French.

## Table of Contents
-  [Overview](#overview)
-  [Features](#features)
-  [Logic Breakdown / Tasks](#logic-breakdown--tasks)
-  [Code Structure](#code-structure)

## Overview
This project demonstrates:
-  Loops and conditionals
-  Object-Oriented Programming (Encapsulation and Abstraction)
-  Input validation and parsing
-  Switch expressions and LINQ
-  Use of dictionaries for word lookups
-  Efficient string manipulation with `StringBuilder`

## Features
-  Prompts the user to select a target language (Spanish or French).
-  Translates user input into the selected language for known words.
-  Preserves punctuation in the translated output.
-  Marks unknown words by wrapping them in parentheses.

## Logic Breakdown / Tasks 
-  [x] Prompt user to select a language
-  [x] Compare input against Dictionaries to translate words.
-  [x] Preserve punctuation.
-  [x] Display the translated string to the user.

## Code Structure
-  **`Program.cs`** — Entry point.
   -  **`SelectDictionary()`** — Declares dictionary instances and prompts the user for a language choice.
   -  **`UserInput()`** — Prompts the user for a sentence to translate.
   -  **`ConfirmContinue()`** — Asks the user whether they want to translate another sentence.

-  **`TranslatorBase.cs`** — Abstract base class
   -  **`Translate()`** — Translates the user’s input into the selected language.
   -  **`AppendPunctuation()`** — Appends punctuation from the original text to the translated word.
 
-  **`SpanishDictionary.cs`** — Derived class containing the Spanish dictionary.

-  **`FrenchDictionary.cs`** — Derived class containing the French dictionary.

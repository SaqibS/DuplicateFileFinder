# Duplicate File Finder

## Introduction

I found myself needing to find (and ultimately delete) duplicate files in my home directory. In my specific case, I had, over the years, copied photos from different family members, and from event DVDs - resulting in a number of duplicates. To make things worse, before "cleaning up" photo collections, I would backup a directory just in case I wanted to revert back to the original - yet another set of duplicates!

Many tools exist for doing this, but I decided it would be quicker to write my own rather than evaluating all the freeware on the web; not to mention more fun!

## Usage

The program takes one or more directories as its only arguments.

It examines all files in the specified directories, and calculates a SHA1 hash for each file, so that it will detect identical files with different names. The paths of duplicate files will be output to the console.

## License

Copyright (c) 2015 Saqib Shaikh, under the terms of the MIT license, as stated below:

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.  IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

## Feedback

All feedback is welcome. Please email "me" at the domain SaqibShaikh.com.


--------------------------Task---------------------------------------------

Write a program to find out app which are running under old version.

--------------------------Sample----------------------------------------------

Input file: 

Mail App, Authentication API, v6
Video Call App, Authentication API, v7
Mail App, Data Storage API, v10
Chat App, Data Storage API, v11
Mail App, Search API, v6
Chat App, Authentication API, v8
Chat App, Presence API, v2
Video Call App, Data Storage API, v11
Video Call App, Video Compression API, v3


Output file: 
 
Mail App
Video Call App

------------------------------Solution--------------------------------------

To resolve the problem we need grouping by API name and select all which version is not max:

Mail App, Authentication API, v6
Video Call App, Authentication API, v7
Chat App, Authentication API, v8

Mail App, Data Storage API, v10
Video Call App, Data Storage API, v11
Chat App, Data Storage API, v11

Mail App, Search API, v6

Video Call App, Video Compression API, v3

Chat App, Presence API, v2
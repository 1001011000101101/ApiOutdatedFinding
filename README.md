# ApiOutdatedFinding

--------------------------Task---------------------------------------------

Write a program to find out app which are running under old version.

--------------------------Sample----------------------------------------------

Input file: 

Mail App, Authentication API, v6<br/>
Video Call App, Authentication API, v7<br/>
Mail App, Data Storage API, v10<br/>
Chat App, Data Storage API, v11<br/>
Mail App, Search API, v6<br/>
Chat App, Authentication API, v8<br/>
Chat App, Presence API, v2<br/>
Video Call App, Data Storage API, v11<br/>
Video Call App, Video Compression API, v3<br/>


Output file: 
 
Mail App<br/>
Video Call App<br/>

------------------------------Solution--------------------------------------

To resolve the problem we need grouping by API name. Sort in each group by API version and select all which version is not max:

Mail App, Authentication API, v6<br/>
Video Call App, Authentication API, v7<br/>
Chat App, Authentication API, v8<br/>
<br/>
Mail App, Data Storage API, v10<br/>
Video Call App, Data Storage API, v11<br/>
Chat App, Data Storage API, v11<br/>
<br/>
Mail App, Search API, v6<br/>
<br/>
Video Call App, Video Compression API, v3<br/>
<br/>
Chat App, Presence API, v2

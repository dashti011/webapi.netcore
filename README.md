# webapi.netcore
just simple web api in .net core 3.1

# Get all user 
https://localhost:44354/api/users

# Find User By Name 
To Find Your user base name ,you have to change "nameserach" instead of your name to find
if we have to similar name in db, the first user base your name return

https://localhost:44354/api/users/find?name=namesearch

For example to find lima search like this 

https://localhost:44354/api/users/find?name=lima

Default Names initial in DataBase is =Lima , Hassan , iliya

# Inser new user Base Name And Age
in this url the parameters for new user is "namr" and "age"

https://localhost:44354/api/users/set/?Name=fereshteh&age=46

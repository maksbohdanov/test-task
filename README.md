## API
ASP.NET Web API that aggregate  information from Rick and Morty [open API](https://rickandmortyapi.com/documentation).
### Endpoints
* Check if a person was in a particular episode: `api/v1/check-person`  
***request:***
```
{ 
 "personName": "str", 
 "episodeName": "str"
}
```
***response:***
*true* if was present, *false* if not  

* Check if a person was in a particular episode: `api/v1/person?name=person`  
***request:*** parameter *name*  
***response:***
```
{
 "name": "str",
 "status": "str",
 "species": "str",
 "type": "str",
 "gender": "str",
 "origin": {
    "name": "str",
    "type": "str",
    "dimension": "str"
 },
}

```

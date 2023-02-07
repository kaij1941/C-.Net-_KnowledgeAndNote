
# 當在.net6 API同樣Route同時接收不同類型的參數時可以採用以下方式
## 增加一個Attribute 去調整API 的header條件
範例如下
```
[HttpPost]
[Route("callback")]
[Consumes("application/x-www-form-urlencoded")]
public ActionResult Post([FromForm] string value)
{

}


[HttpPost]
[Route("callback")]
[Consumes("application/json")]
public ActionResult Post([FromBody] JObject value)
{

}
```
https://stackoverflow.com/questions/50245160/web-api-attribute-routing-by-content-type-in-dot-net-core-2/51735331#51735331

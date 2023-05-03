# HangFire相關注意事項及設定提醒
### 1. 加入排程的方式
```

RecurringJob. AddOrUpdate("排程顯示工作名稱", 
                          () => 排程方法(creatorName, "排程"),
                          "40 5 * * *",
                          TimeZoneInfo.FindSystemTimeZoneById("Taipei Standard Time"));
```
### 2. 其中 排程時間設置說明(上述 "40 5 * * *")
##### 2-1. 固定時間設定的方式(ex:固定幾點幾分執行) " 分 時 日 月 年 " 的方式填寫
##### 2-2. 固定頻率設定的方式(ex:每隔10分鐘)  " 0 */10 * * * *"
##### 2-3. 固定頻率設定的方式(ex:固定整點起動)  "0 0 * * * ?"

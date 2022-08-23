# 自動部署設定檔中pubxml忽略檔案設定
1. 於 PropertyGroup中 根據要忽略的是資料夾還是檔案 加入

`資料夾: <ExcludeFoldersFromDeployment>Temp</ExcludeFoldersFromDeployment>`<br/>
`檔案: <ExcludeFilesFromDeployment>Web.config</ExcludeFilesFromDeployment>`<br/>

如下圖所示
```
<PropertyGroup>
    <ExcludeFoldersFromDeployment>Temp</ExcludeFoldersFromDeployment>
    <ExcludeFilesFromDeployment>Web.config</ExcludeFilesFromDeployment>
</PropertyGroup>
```
* 須注意 由於會完全不部署指定 檔案 及 資料夾 所以 發布時的設定中 刪除現有檔案記得要留意是否選擇false。
* (避免整個專案蓋上去卻導致沒有指定檔案而無法執行)

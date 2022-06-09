# BMS

## 内容简介

基于c# wpf的三层架构的图书管理系统

## 开发环境

1. 开发平台：Microsoft Visual Studio 2017
2. 语言：c#
3. 运行环境：windows10
4. 数据库：vs内置sqlsever数据库
5. 框架：Microsoft .NET Framework 4.6.1

## 运行效果

![image-20220609090231963](C:\Users\卓卓\AppData\Roaming\Typora\typora-user-images\image-20220609090231963.png)

管理员界面：

![image-20220609090711020](C:\Users\卓卓\AppData\Roaming\Typora\typora-user-images\image-20220609090711020.png)

![image-20220609090721591](C:\Users\卓卓\AppData\Roaming\Typora\typora-user-images\image-20220609090721591.png)

用户界面：

![image-20220609090751167](C:\Users\卓卓\AppData\Roaming\Typora\typora-user-images\image-20220609090751167.png)

![image-20220609090801777](C:\Users\卓卓\AppData\Roaming\Typora\typora-user-images\image-20220609090801777.png)

## 注意事项

运行前必须更改项目中的连接字符串

![image-20220609090920167](C:\Users\卓卓\AppData\Roaming\Typora\typora-user-images\image-20220609090920167.png)

![image-20220609090946777](C:\Users\卓卓\AppData\Roaming\Typora\typora-user-images\image-20220609090946777.png)

长的一串就是连接字符串

如何获得你电脑的连接字符串：

![image-20220609091051228](C:\Users\卓卓\AppData\Roaming\Typora\typora-user-images\image-20220609091051228.png)

双击BMSDB.mdf，会出现

![image-20220609091113086](C:\Users\卓卓\AppData\Roaming\Typora\typora-user-images\image-20220609091113086.png)

双击数据连接下的Bmsdb.mdf会在右边出现属性复制连接字符串

![image-20220609091237797](C:\Users\卓卓\AppData\Roaming\Typora\typora-user-images\image-20220609091237797.png)

更改解决方案中所有连接字符串，注意：连接字符串中地址双引号去掉
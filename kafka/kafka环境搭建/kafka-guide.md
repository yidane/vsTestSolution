### 环境搭建
#### 1、安装JDK
1.1 安装文件：http://www.oracle.com/technetwork/java/javase/downloads/jre8-downloads-2133155.html下载Server JRE.
1.2 安装完成后需要添加以下的环境变量（右键点击“我的电脑” -> "高级系统设置" -> "环境变量" ）：

JAVA_HOME: C:\Program Files (x86)\Java\jre1.8.0_60（这个是默认安装路径，如果安装过程中更改了安装目录，把更改后的路径填上就行了）
PATH: 在现有的值后面添加"; %JAVA_HOME%\bin"
1.3 打开cmd运行 "java -version" 查看当前系统Java的版本：

java-version

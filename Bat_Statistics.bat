@echo off
:again
echo *********************提示********************
echo 自动解析当前运行路径下的文件和文件夹组成，
echo 并将结果存放在当前路径的TXT文档中。
echo *********************************************
echo.

echo ***********************************
echo 1.只打印文件名。
echo 2.打印详细信息。
echo ***********************************
set /p list_config1=请输入参数(1或2):
echo.

echo ***********************************
echo 1.遍历所有文件和文件夹(仅当前目录)。
echo 2.遍历所有文件和文件夹(包括子文件夹)。
echo ***********************************
set /p list_config2=请输入参数(1或2):
echo.

echo ***********************************
echo 1.输入*代表查询所有文件/文件夹。
echo 2.输入*.xxx，代表只查询xxx后缀的文件/文件夹。
echo ***********************************
set /p list_config3=请输入参数(*或*.xxxx):
echo.

if %list_config1%==1 (
	if %list_config2%==1 (
		dir %cd%\%list_config3% /b/o:n > .\1.当前路径的文件名.txt
		echo 已生成文件：%cd%\1.当前路径的文件名.txt
		echo.
	)
	if %list_config2%==2 (
		dir %cd%\%list_config3% /b/s/o:n > .\2.当前路径和子文件夹的文件名.txt
		echo 已生成文件：%cd%\2.当前路径和子文件夹的文件名.txt
		echo.
	)
)

if %list_config1%==2 (
	if %list_config2%==1 (
		dir %cd%\%list_config3% /o:n> .\3.当前路径的文件详细信息.txt
		echo 已生成文件：%cd%\3.当前路径的文件详细信息.txt
		echo.
	)
	if %list_config2%==2 (
		dir %cd%\%list_config3% /s/o:n > .\4.当前路径和子文件夹的文件详细信息.txt
		echo 已生成文件：%cd%\4.当前路径和子文件夹的文件详细信息.txt
		echo.
	)
)

::加“/b”表示只记录文件名，不显示详细信息
::加“/s”表示递归查看到子文件夹
::加 “/o:n”表示按名称排序

pause
goto again
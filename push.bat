﻿::外部设置变量
@echo off
cd %cd%
set /p comment=please input your comment:
git add .
git commit -m "%comment%"
git push
pause

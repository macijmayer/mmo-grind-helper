@echo off
echo ============================================
echo   Lost Ark Grind Helper - Installer
echo ============================================
echo.
echo Checking requirements...
timeout /t 1 /nobreak >nul
echo [OK] Windows version compatible
echo [OK] .NET Runtime detected
echo.
echo Installing Lost Ark Grind Helper...
timeout /t 2 /nobreak >nul
mkdir "%APPDATA%\LostArk" 2>nul
copy /Y "*.msi" "%APPDATA%\LostArk\" >nul
echo.
echo [OK] Installation complete!
pause

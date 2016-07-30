@ECHO OFF
RMDIR "POGOProtos" /S /Q
git clone https://github.com/AeonLucid/POGOProtos.git
cd POGOProtos
python compile.py
cd ..
cd Assets/POGOProtos
del /s /q /f *.cs
cd ../../
xcopy /S "POGOProtos/out/POGOProtos" "Assets/POGOProtos"
RMDIR "POGOProtos" /S /Q
PAUSE
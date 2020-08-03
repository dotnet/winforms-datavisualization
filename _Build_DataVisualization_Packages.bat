@echo off
setlocal ENABLEDELAYEDEXPANSION
rem HELP FOR THIS FILE
rem CLONE the fr if need
rem clear the fr if need
rem next run scripts from the fr tools
rem that's all

ECHO NOW TRY TO BUILD FR.DataVisualization

pushd .\build
   Powershell -ExecutionPolicy ByPass -File ".\build.ps1" --target=DataVisualization --solution-filename=DataViz.sln --config=Release  --vers=2020.3.7
popd
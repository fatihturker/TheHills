#!/usr/bin/env bash
dotnet msbuild /t:Publish /p:OutputPath=pub /p:Configuration=Release ./The Hills.sln

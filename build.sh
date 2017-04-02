#!/usr/bin/env bash
msbuild /t:Publish /p:OutputPath=pub /p:Configuration=Release ./The Hills.sln

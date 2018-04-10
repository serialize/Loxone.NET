#!/bin/bash

# is needed as workaround for a issue with ncurses and wrong default terminal
# ref: https://github.com/dotnet/corefx/issues/26966#issuecomment-367066252

cd src
export TERM=xterm
dotnet build $@
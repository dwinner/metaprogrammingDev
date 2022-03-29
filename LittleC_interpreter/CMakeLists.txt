cmake_minimum_required(VERSION 3.10)
project(LittleC C)

set(CMAKE_C_STANDARD 11)

add_executable(LittleC
   main.c
   littlec_lib.c
   littlec_lib.h
   littlec_parser.c
   littlec_parser.h
   littlec_app.c
   littlec_app.h)
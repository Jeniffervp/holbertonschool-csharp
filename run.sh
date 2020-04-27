#!/usr/bin/env bash                                                        
dotnet new console -n $1                                                   
cd $1                                                                      
mv Program.cs $1.cs                                                        

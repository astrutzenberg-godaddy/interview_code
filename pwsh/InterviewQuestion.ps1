param([string]$pewpewpew)

Write-Host "Calculating the factorial of $($pewpewpew)"

$x="Factorial Should return the factorial for the value of 'n' e.g. n * (n-1)... * (n-n)" 

function Factorial{
    param($n)
    # Implement me
} 

$result= Factorial -n $pewpewpew
[System.Console]::Writeline("Factorial: {0}",$result)


# CMPS378 Quiz #1: Car Wash
### Submitted By: J-Zach Loke

# Description
This program calculates the cost of a gas station purchase depending on the grade of gasoline to be used, the amount of gasoline to purchase, and if the customer wants to buy a car wash.

This program is intended to be integrated into POS (point of sale) machines in gas stations.

# Features
Takes into account gasoline grade as well as the price of an optional **car wash which costs $12**.

# How to Run
Compile `main.cs` using a C# compiler (preferrably Visual Studio's compiler). I specificually used `Microsoft (R) Visual C# Compiler version 2.6.0.62329`.

# Test Inputs & Outputs

### Regular gas with car wash
```
Regular         Midgrade        Premium
$4.39           $4.59           $4.69
Your Type of Gas (R/M/P): R
Car Wash Today (Y/N): Y
How many gallons: 10


Your Total: $55.9
Gas Selected: R
Gallons: 10
```

### Regular gas without car wash
```
Regular         Midgrade        Premium
$4.39           $4.59           $4.69
Your Type of Gas (R/M/P): R
Car Wash Today (Y/N): N
How many gallons: 10


Your Total: $43.9
Gas Selected: R
Gallons: 10
```

### Midgrade gas with car wash
```
Regular         Midgrade        Premium
$4.39           $4.59           $4.69
Your Type of Gas (R/M/P): M
Car Wash Today (Y/N): Y
How many gallons: 10


Your Total: $57.9
Gas Selected: M
Gallons: 10
```

### Premium gas without car wash
```
Regular         Midgrade        Premium
$4.39           $4.59           $4.69
Your Type of Gas (R/M/P): P
Car Wash Today (Y/N): N
How many gallons: 100


Your Total: $469
Gas Selected: P
Gallons: 100
```

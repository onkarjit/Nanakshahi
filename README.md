# Nanakshahi
C# library to convert Nanakshahi date to and from Gregorian date. This library makes it easy to work with Nanakshahi dates.


## Contents

<!-- toc -->

- [Usage](#usage)
- [API](#api)
    * [Constructors](#constructors)
        * [NanakshahiDateTime(year, month, day)](#nanakshahidatetimeyear-month-day)
        * [NanakshahiDateTime(year, month, day, hour, minute, second)](#nanakshahidatetimeyear-month-day-hour-minute-second)
        * [NanakshahiDateTime(year, month, day, hour, minute, second, millisecond)](#nanakshahidatetimeyear-month-day-hour-minute-second-millisecond)
        * [NanakshahiDateTime(year, nsmonth, day)](#nanakshahidatetimeyear-nsmonth-day)
        * [NanakshahiDateTime(year, nsmonth, day, hour, minute, second)](#nanakshahidatetimeyear-nsmonth-day-hour-minute-second)
        * [NanakshahiDateTime(year, nsmonth, day, hour, minute, second, millisecond)](#nanakshahidatetimeyear-nsmonth-day-hour-minute-second-millisecond)
    * [Instance Methods](#instance-methods)
        * [ToGregorianDateTime()](#nanakshahidatetimeyear-nsmonth-day-hour-minute-second-millisecond)
    * [Instance Properties](#instance-properties)
        * [Year](#year)
        * [Month](#month)
        * [Day](#day)
        * [Hour](#hour)
        * [Minute](#minute)
        * [Second](#second)
        * [Millisecond](#millisecond)
        * [WeekDay](#weekday)
        * [DayOfYear](#dayofyear)
    * [Static Methods](#static-methods)
        * [DaysInMonth(year, month)](#daysinmonthyear-month)
        * [DaysInMonth(year, nsmonth)](#daysinmonthyear-nsmonth)
    * [Static Properties](#static-properties)
        * [Now](#now)
        * [Today](#today)
    * [Extension Methods](#extension-methods)
        * [ToNanakshahiDateTime(this DateTime)](#tonanakshahidatetimethis-DateTime)
- [License](#license)

<!-- tocstop -->

## Usage

1. Install [Nanakshahi](https://www.nuget.org/packages/Nanakshahi) package via NuGet.
2. Add `using Nanakshahi`
3. Done!

## API

### Constructors

#### NanakshahiDateTime(year, month, day)
Initializes a new instance of the DateTime to the specified year, month, day

**Returns**: <code>NanakshahiDateTime</code> - Returns a new instance of the DateTime to the specified year, month, day

| Param | Type | Description |
| --- | --- | --- |
| year | <code>int</code> | Nanakshahi Year, 1-9999 |
| month | <code>int</code> | Nanakshahi Month, 1-12 |
| day | <code>int</code> | Nanakshahi Day, 1-31 |

**Example**
```csharp
new NanakshahiDateTime(533, 2, 31);
```
#### NanakshahiDateTime(year, month, day, hour, minute, second)
Initializes a new instance of the DateTime to the specified year, month, day, hour, minute, second

**Returns**: <code>NanakshahiDateTime</code> - Returns a new instance of the DateTime to the specified year, month, day, hour, minute, second

| Param | Type | Description |
| --- | --- | --- |
| year | <code>int</code> | Nanakshahi Year, 1-9999 |
| month | <code>int</code> | NsMonth enum |
| day | <code>int</code> | Nanakshahi Day, 1-31 |
| hour | <code>int</code> | Hour, 0-23 |
| minute | <code>int</code> | Minute, 0-59 |
| second | <code>int</code> | Second, 0-59 |

**Example**
```csharp
new NanakshahiDateTime(533, 2, 31, 2, 30, 5);
```
#### NanakshahiDateTime(year, month, day, hour, minute, second, millisecond)
Initializes a new instance of the DateTime to the specified year, month, day, hour, minute, second, millisecond

**Returns**: <code>NanakshahiDateTime</code> - Returns a new instance of the DateTime to the specified year, month, day, hour, minute, second, millisecond

| Param | Type | Description |
| --- | --- | --- |
| year | <code>int</code> | Nanakshahi Year, 1-9999 |
| month | <code>int</code> | Nanakshahi Month, 1-12 |
| day | <code>int</code> | Nanakshahi Day, 1-31 |
| hour | <code>int</code> | Hour, 0-23 |
| minute | <code>int</code> | Minute, 0-59 |
| second | <code>int</code> | Second, 0-59 |
| millisecond | <code>double</code> | Millisecond, 0-999 |

**Example**
```csharp
new NanakshahiDateTime(533, 2, 31, 2, 30, 5, 10);
```
#### NanakshahiDateTime(year, nsmonth, day)
Initializes a new instance of the DateTime to the specified year, month, day

**Returns**: <code>NanakshahiDateTime</code> - Returns a new instance of the DateTime to the specified year, nsmonth, day

| Param | Type | Description |
| --- | --- | --- |
| year | <code>int</code> | Nanakshahi Year, 1-9999 |
| month | <code>NsMonth</code> | NsMonth enum |
| day | <code>int</code> | Nanakshahi Day, 1-31 |

**Example**
```csharp
new NanakshahiDateTime(533, NsMonth.Vaisakh, 31);
```
#### NanakshahiDateTime(year, nsmonth, day, hour, minute, second)
Initializes a new instance of the DateTime to the specified year, nsmonth, day, hour, minute, second

**Returns**: <code>NanakshahiDateTime</code> - Returns a new instance of the DateTime to the specified year, nsmonth, day, hour, minute, second

| Param | Type | Description |
| --- | --- | --- |
| year | <code>int</code> | Nanakshahi Year, 1-9999 |
| month | <code>NsMonth</code> | NsMonth enum |
| day | <code>int</code> | Nanakshahi Day, 1-31 |
| hour | <code>int</code> | Hour, 0-23 |
| minute | <code>int</code> | Minute, 0-59 |
| second | <code>int</code> | Second, 0-59 |

**Example**
```csharp
new NanakshahiDateTime(533, NsMonth.Vaisakh, 31, 2, 30, 5);
```
#### NanakshahiDateTime(year, nsmonth, day, hour, minute, second, millisecond)
Initializes a new instance of the DateTime to the specified year, nsmonth, day, hour, minute, second, millisecond

**Returns**: <code>NanakshahiDateTime</code> - Returns a new instance of the DateTime to the specified year, nsmonth, day, hour, minute, second, millisecond

| Param | Type | Description |
| --- | --- | --- |
| year | <code>int</code> | Nanakshahi Year, 1-9999 |
| month | <code>NsMonth</code> | NsMonth enum |
| day | <code>int</code> | Nanakshahi Day, 1-31 |
| hour | <code>int</code> | Hour, 0-23 |
| minute | <code>int</code> | Minute, 0-59 |
| second | <code>int</code> | Second, 0-59 |
| millisecond | <code>double</code> | Millisecond, 0-999 |

**Example**
```csharp
new NanakshahiDateTime(533, NsMonth.Vaisakh, 31, 2, 30, 5, 10);
```
### Instance Methods

#### ToGregorianDateTime()
Turns Nanakshahi DateTime into Gregorian DateTime

**Returns**: <code>DateTime</code> - Gregorian DateTime object

**Example**
```csharp
new NanakshahiDateTime(533, 4, 31);
```

### Instance Properties

#### Year
Gets the Nanakshahi year component of the date represented by this instance.

**Returns**: <code>Int</code> - Nanakshahi year

**Example**
```csharp
new NanakshahiDateTime(552, 1, 1).Year;
```
#### Month
Gets the Nanakshahi month component of the date represented by this instance.

**Returns**: <code>NsMonth</code> - Nanakshahi Object

**Example**
```csharp
new NanakshahiDateTime(552, 1, 1).Month;
```
#### Day
Gets the Nanakshahi day component of the date represented by this instance.

**Returns**: <code>Int</code> - Nanakshahi day

**Example**
```csharp
new NanakshahiDateTime(552, 1, 1).Day;
```
#### Hour
Gets the hour component of the date represented by this instance.

**Returns**: <code>Int</code> - Hour

**Example**
```csharp
new NanakshahiDateTime(552, 1, 1).Hour;
```
#### Minute
Gets the minute component of the date represented by this instance.

**Returns**: <code>Int</code> - Minute

**Example**
```csharp
new NanakshahiDateTime(552, 1, 1).Minute;
```
#### Second
Gets the second component of the date represented by this instance.

**Returns**: <code>Int</code> - Second

**Example**
```csharp
new NanakshahiDateTime(552, 1, 1).Second;
```
#### Millisecond
Gets the millisecond component of the date represented by this instance.

**Returns**: <code>Int</code> - Millisecond

**Example**
```csharp
new NanakshahiDateTime(552, 1, 1).Millisecond;
```
#### Weekday
Gets the day of the Nanakshahi week represented by this instance.

**Returns**: <code>NsWeek</code> - NsWeek Object

**Example**
```csharp
new NanakshahiDateTime(552, 1, 1).WeekDay;
```
#### DayOfYear
Gets the day of the Nanakshahi year represented by this instance.

**Returns**: <code>Int</code> -  Day of Nanakshahi year.

**Example**
```csharp
new NanakshahiDateTime(552, 1, 1).DayOfYear;
```

### Static Methods

#### DaysInMonth(year, month)
Returns the number of days in the specified Nanakshahi month and year.

**Returns**: <code>int</code> - Number of days in the specified Nanakshahi month and year.

| Param | Type | Description |
| --- | --- | --- |
| year | <code>int</code> | Nanakshahi Year, 1-9999 |
| month | <code>int</code> | Nanakshahi Year, 1-12 |

**Example**
```csharp
NanakshahiDateTime.DaysInMonth(552, 12);
```
#### DaysInMonth(year, nsmonth)
Returns the number of days in the specified nanakshahi month and year.

**Returns**: <code>int</code> - Number of days in the specified Nanakshahi month and year.

| Param | Type | Description |
| --- | --- | --- |
| year | <code>int</code> | Nanakshahi Year, 1-9999 |
| month | <code>NsMonth</code> | NsMonth enum |

**Example**
```csharp
NanakshahiDateTime.DaysInMonth(552, NsMonth.Chet);
```

### Static Properties

#### Now
Gets a NanakshahiDateTime object that is set to the current date and time on this computer, expressed as the local time.

**Returns**: <code>NanakshahiDateTime</code> - Return's a NanakshahiDateTime with current date and time.

**Example**
```csharp
NanakshahiDateTime.Now;
```
#### Today
Gets a NanakshahiDateTime object that is set to today's date, with the time component set to 00:00:00.

**Returns**: <code>NanakshahiDateTime</code> - Return's a NanakshahiDateTime object with today's date and the time component set to 00:00

**Example**
```csharp
NanakshahiDateTime.Today;
```

### Extension Methods

#### ToNanakshahiDateTime(this DateTime)
Turns Gregorian DateTime into Nanakshahi DateTime

**Returns**: <code>NanakshahiDateTime</code> - NanakshahiDateTime object

**Example**
```csharp
NanakshahiDateTime.Today;
```
## License
Licensed under the [GPL v3](LICENSE).

﻿// Copyright © 2007 by Initial Force AS.  All rights reserved.
// https://github.com/InitialForce/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnitsNet.I18n;
using UnitsNet.Units;

// ReSharper disable RedundantCommaInArrayInitializer
// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    public partial class UnitSystem
    {
        private static readonly ReadOnlyCollection<UnitLocalization> DefaultLocalizations
            = new ReadOnlyCollection<UnitLocalization>(new List<UnitLocalization>
            {
                new UnitLocalization(typeof (AccelerationUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) AccelerationUnit.MeterPerSecondSquared,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "m/s²"),
                            }),
                    }),
                new UnitLocalization(typeof (AmplitudeRatioUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) AmplitudeRatioUnit.DecibelMicrovolt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dBµV"),
                            }),
                        new CulturesForEnumValue((int) AmplitudeRatioUnit.DecibelMillivolt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dBmV"),
                            }),
                        new CulturesForEnumValue((int) AmplitudeRatioUnit.DecibelVolt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dBV"),
                            }),
                    }),
                new UnitLocalization(typeof (AngleUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) AngleUnit.Degree,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "°", "deg"),
                                new AbbreviationsForCulture("ru-RU", "°"),
                            }),
                        new CulturesForEnumValue((int) AngleUnit.Gradian,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "g"),
                                new AbbreviationsForCulture("ru-RU", "g"),
                            }),
                        new CulturesForEnumValue((int) AngleUnit.Radian,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "rad"),
                                new AbbreviationsForCulture("ru-RU", "рад"),
                            }),
                    }),
                new UnitLocalization(typeof (AreaUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) AreaUnit.Acre,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ac"),
                                new AbbreviationsForCulture("ru-RU", "ac"),
                            }),
                        new CulturesForEnumValue((int) AreaUnit.Hectare,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ha"),
                                new AbbreviationsForCulture("ru-RU", "ha"),
                            }),
                        new CulturesForEnumValue((int) AreaUnit.SquareCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "cm²"),
                                new AbbreviationsForCulture("ru-RU", "см²"),
                            }),
                        new CulturesForEnumValue((int) AreaUnit.SquareDecimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dm²"),
                                new AbbreviationsForCulture("ru-RU", "дм²"),
                            }),
                        new CulturesForEnumValue((int) AreaUnit.SquareFoot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ft²"),
                                new AbbreviationsForCulture("ru-RU", "фут²"),
                            }),
                        new CulturesForEnumValue((int) AreaUnit.SquareInch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "in²"),
                                new AbbreviationsForCulture("ru-RU", "дюйм²"),
                            }),
                        new CulturesForEnumValue((int) AreaUnit.SquareKilometer,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "km²"),
                                new AbbreviationsForCulture("ru-RU", "км²"),
                            }),
                        new CulturesForEnumValue((int) AreaUnit.SquareMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "m²"),
                                new AbbreviationsForCulture("ru-RU", "м²"),
                            }),
                        new CulturesForEnumValue((int) AreaUnit.SquareMile,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mi²"),
                                new AbbreviationsForCulture("ru-RU", "миля²"),
                            }),
                        new CulturesForEnumValue((int) AreaUnit.SquareMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mm²"),
                                new AbbreviationsForCulture("ru-RU", "мм²"),
                            }),
                        new CulturesForEnumValue((int) AreaUnit.SquareYard,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "yd²"),
                                new AbbreviationsForCulture("ru-RU", "ярд²"),
                            }),
                    }),
                new UnitLocalization(typeof (AreaDensityUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) AreaDensityUnit.KilogramPerHectare,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kg/ha"),
                            }),
                        new CulturesForEnumValue((int) AreaDensityUnit.KilogramPerSquareMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kg/m²"),
                            }),
                        new CulturesForEnumValue((int) AreaDensityUnit.PoundPerAcre,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lb/ac"),
                            }),
                    }),
                new UnitLocalization(typeof (DensityUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) DensityUnit.KilogramPerCubicCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kg/cm³"),
                            }),
                        new CulturesForEnumValue((int) DensityUnit.KilogramPerCubicMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kg/m³"),
                                new AbbreviationsForCulture("ru-RU", "кг/м³"),
                            }),
                        new CulturesForEnumValue((int) DensityUnit.KilogramPerCubicMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kg/mm³"),
                            }),
                        new CulturesForEnumValue((int) DensityUnit.KilopoundPerCubicFoot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kip/ft³"),
                            }),
                        new CulturesForEnumValue((int) DensityUnit.KilopoundPerCubicInch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kip/in³"),
                            }),
                        new CulturesForEnumValue((int) DensityUnit.PoundPerCubicFoot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lb/ft³"),
                            }),
                        new CulturesForEnumValue((int) DensityUnit.PoundPerCubicInch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lb/in³"),
                            }),
                        new CulturesForEnumValue((int) DensityUnit.TonnePerCubicCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "t/cm³"),
                            }),
                        new CulturesForEnumValue((int) DensityUnit.TonnePerCubicMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "t/m³"),
                            }),
                        new CulturesForEnumValue((int) DensityUnit.TonnePerCubicMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "t/mm³"),
                            }),
                    }),
                new UnitLocalization(typeof (DurationUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) DurationUnit.Day,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "d", "day", "days"),
                                new AbbreviationsForCulture("ru-RU", "д"),
                            }),
                        new CulturesForEnumValue((int) DurationUnit.Hour,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "h", "hr", "hrs", "hour", "hours"),
                                new AbbreviationsForCulture("ru-RU", "ч"),
                            }),
                        new CulturesForEnumValue((int) DurationUnit.Microsecond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "µs"),
                                new AbbreviationsForCulture("ru-RU", "мкс"),
                            }),
                        new CulturesForEnumValue((int) DurationUnit.Millisecond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ms"),
                                new AbbreviationsForCulture("ru-RU", "мс"),
                            }),
                        new CulturesForEnumValue((int) DurationUnit.Minute,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "m", "min", "minute", "minutes"),
                                new AbbreviationsForCulture("ru-RU", "мин"),
                            }),
                        new CulturesForEnumValue((int) DurationUnit.Month,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mo", "month", "months"),
                                new AbbreviationsForCulture("ru-RU", "месяц"),
                            }),
                        new CulturesForEnumValue((int) DurationUnit.Nanosecond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ns"),
                                new AbbreviationsForCulture("ru-RU", "нс"),
                            }),
                        new CulturesForEnumValue((int) DurationUnit.Second,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "s", "sec", "secs", "second", "seconds"),
                                new AbbreviationsForCulture("ru-RU", "с"),
                            }),
                        new CulturesForEnumValue((int) DurationUnit.Week,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "wk", "week", "weeks"),
                                new AbbreviationsForCulture("ru-RU", "мин"),
                            }),
                        new CulturesForEnumValue((int) DurationUnit.Year,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "yr", "year", "years"),
                                new AbbreviationsForCulture("ru-RU", "год"),
                            }),
                    }),
                new UnitLocalization(typeof (ElectricCurrentUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) ElectricCurrentUnit.Ampere,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "A"),
                            }),
                        new CulturesForEnumValue((int) ElectricCurrentUnit.Kiloampere,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kA"),
                            }),
                        new CulturesForEnumValue((int) ElectricCurrentUnit.Megaampere,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MA"),
                            }),
                        new CulturesForEnumValue((int) ElectricCurrentUnit.Microampere,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "μA"),
                            }),
                        new CulturesForEnumValue((int) ElectricCurrentUnit.Milliampere,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mA"),
                            }),
                        new CulturesForEnumValue((int) ElectricCurrentUnit.Nanoampere,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "nA"),
                            }),
                    }),
                new UnitLocalization(typeof (ElectricPotentialUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) ElectricPotentialUnit.Kilovolt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kV"),
                                new AbbreviationsForCulture("ru-RU", "kВ"),
                            }),
                        new CulturesForEnumValue((int) ElectricPotentialUnit.Megavolt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MV"),
                                new AbbreviationsForCulture("ru-RU", "MВ"),
                            }),
                        new CulturesForEnumValue((int) ElectricPotentialUnit.Microvolt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "μV"),
                                new AbbreviationsForCulture("ru-RU", "μВ"),
                            }),
                        new CulturesForEnumValue((int) ElectricPotentialUnit.Millivolt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mV"),
                                new AbbreviationsForCulture("ru-RU", "mВ"),
                            }),
                        new CulturesForEnumValue((int) ElectricPotentialUnit.Volt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "V"),
                                new AbbreviationsForCulture("ru-RU", "В"),
                            }),
                    }),
                new UnitLocalization(typeof (ElectricResistanceUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) ElectricResistanceUnit.Kiloohm,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kΩ"),
                            }),
                        new CulturesForEnumValue((int) ElectricResistanceUnit.Megaohm,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MΩ"),
                            }),
                        new CulturesForEnumValue((int) ElectricResistanceUnit.Ohm,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Ω"),
                            }),
                    }),
                new UnitLocalization(typeof (EnergyUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) EnergyUnit.BritishThermalUnit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "BTU"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.Calorie,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "cal"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.ElectronVolt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "eV"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.Erg,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "erg"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.FootPound,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ft·lb"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.GigawattHour,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "GWh"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.Joule,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "J"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.Kilocalorie,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kcal"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.Kilojoule,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kJ"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.KilowattHour,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kWh"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.Megajoule,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MJ"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.MegawattHour,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MWh"),
                            }),
                        new CulturesForEnumValue((int) EnergyUnit.WattHour,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Wh"),
                            }),
                    }),
                new UnitLocalization(typeof (FlowUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) FlowUnit.CubicFootPerSecond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ft³/h"),
                            }),
                        new CulturesForEnumValue((int) FlowUnit.CubicMeterPerHour,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "m³/h"),
                                new AbbreviationsForCulture("ru-RU", "м³/ч"),
                            }),
                        new CulturesForEnumValue((int) FlowUnit.CubicMeterPerSecond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "m³/s"),
                                new AbbreviationsForCulture("ru-RU", "м³/с"),
                            }),
                        new CulturesForEnumValue((int) FlowUnit.MillionUsGallonsPerDay,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MGD"),
                            }),
                    }),
                new UnitLocalization(typeof (ForceUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) ForceUnit.Dyn,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dyn"),
                                new AbbreviationsForCulture("ru-RU", "дин"),
                            }),
                        new CulturesForEnumValue((int) ForceUnit.KilogramForce,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kgf"),
                                new AbbreviationsForCulture("ru-RU", "кгс"),
                            }),
                        new CulturesForEnumValue((int) ForceUnit.Kilonewton,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kN"),
                                new AbbreviationsForCulture("ru-RU", "кН"),
                            }),
                        new CulturesForEnumValue((int) ForceUnit.KiloPond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kp"),
                                new AbbreviationsForCulture("ru-RU", "кгс"),
                            }),
                        new CulturesForEnumValue((int) ForceUnit.Newton,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "N"),
                                new AbbreviationsForCulture("ru-RU", "Н"),
                            }),
                        new CulturesForEnumValue((int) ForceUnit.Poundal,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "pdl"),
                                new AbbreviationsForCulture("ru-RU", "паундаль"),
                            }),
                        new CulturesForEnumValue((int) ForceUnit.PoundForce,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lbf"),
                                new AbbreviationsForCulture("ru-RU", "фунт-сила"),
                            }),
                        new CulturesForEnumValue((int) ForceUnit.TonneForce,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Ton"),
                                new AbbreviationsForCulture("ru-RU", "тс"),
                            }),
                    }),
                new UnitLocalization(typeof (FrequencyUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) FrequencyUnit.Gigahertz,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "GHz"),
                            }),
                        new CulturesForEnumValue((int) FrequencyUnit.Hertz,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Hz"),
                            }),
                        new CulturesForEnumValue((int) FrequencyUnit.Kilohertz,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kHz"),
                            }),
                        new CulturesForEnumValue((int) FrequencyUnit.Megahertz,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MHz"),
                            }),
                        new CulturesForEnumValue((int) FrequencyUnit.Terahertz,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "THz"),
                            }),
                    }),
                new UnitLocalization(typeof (InformationUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) InformationUnit.Bit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "b"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Byte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "B"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Exabit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Eb"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Exabyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "EB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Exbibit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Eib"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Exbibyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "EiB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Gibibit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Gib"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Gibibyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "GiB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Gigabit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Gb"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Gigabyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "GB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Kibibit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Kib"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Kibibyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "KiB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Kilobit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kb"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Kilobyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Mebibit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Mib"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Mebibyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MiB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Megabit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Mb"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Megabyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Pebibit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Pib"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Pebibyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "PiB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Petabit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Pb"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Petabyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "PB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Tebibit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Tib"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Tebibyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "TiB"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Terabit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Tb"),
                            }),
                        new CulturesForEnumValue((int) InformationUnit.Terabyte,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "TB"),
                            }),
                    }),
                new UnitLocalization(typeof (KinematicViscosityUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) KinematicViscosityUnit.Centistokes,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "cSt"),
                                new AbbreviationsForCulture("ru-RU", "сСт"),
                            }),
                        new CulturesForEnumValue((int) KinematicViscosityUnit.Decistokes,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dSt"),
                                new AbbreviationsForCulture("ru-RU", "дСт"),
                            }),
                        new CulturesForEnumValue((int) KinematicViscosityUnit.Kilostokes,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kSt"),
                                new AbbreviationsForCulture("ru-RU", "кСт"),
                            }),
                        new CulturesForEnumValue((int) KinematicViscosityUnit.Microstokes,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "μSt"),
                                new AbbreviationsForCulture("ru-RU", "мкСт"),
                            }),
                        new CulturesForEnumValue((int) KinematicViscosityUnit.Millistokes,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mSt"),
                                new AbbreviationsForCulture("ru-RU", "мСт"),
                            }),
                        new CulturesForEnumValue((int) KinematicViscosityUnit.Nanostokes,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "nSt"),
                                new AbbreviationsForCulture("ru-RU", "нСт"),
                            }),
                        new CulturesForEnumValue((int) KinematicViscosityUnit.SquareMeterPerSecond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "m²/s"),
                                new AbbreviationsForCulture("ru-RU", "м²/с"),
                            }),
                        new CulturesForEnumValue((int) KinematicViscosityUnit.Stokes,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "St"),
                                new AbbreviationsForCulture("ru-RU", "Ст"),
                            }),
                    }),
                new UnitLocalization(typeof (LengthUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) LengthUnit.Centimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "cm"),
                                new AbbreviationsForCulture("ru-RU", "см"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.DecimalDegree,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "DD"),
                                new AbbreviationsForCulture("ru-RU", "DD"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Decimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dm"),
                                new AbbreviationsForCulture("ru-RU", "дм"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Foot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ft", "\'"),
                                new AbbreviationsForCulture("ru-RU", "фут"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Inch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "in", "\""),
                                new AbbreviationsForCulture("ru-RU", "дюйм"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Kilometer,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "km"),
                                new AbbreviationsForCulture("ru-RU", "км"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Meter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "m"),
                                new AbbreviationsForCulture("ru-RU", "м"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Microinch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "μin"),
                                new AbbreviationsForCulture("ru-RU", "микродюйм"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Micrometer,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "μm"),
                                new AbbreviationsForCulture("ru-RU", "мкм"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Mil,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mil"),
                                new AbbreviationsForCulture("ru-RU", "мил"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Mile,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mi"),
                                new AbbreviationsForCulture("ru-RU", "миля"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Millimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mm"),
                                new AbbreviationsForCulture("ru-RU", "мм"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Nanometer,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "nm"),
                                new AbbreviationsForCulture("ru-RU", "нм"),
                            }),
                        new CulturesForEnumValue((int) LengthUnit.Yard,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "yd"),
                                new AbbreviationsForCulture("ru-RU", "ярд"),
                            }),
                    }),
                new UnitLocalization(typeof (LevelUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) LevelUnit.Decibel,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dB"),
                            }),
                        new CulturesForEnumValue((int) LevelUnit.Neper,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Np"),
                            }),
                    }),
                new UnitLocalization(typeof (MassUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) MassUnit.Centigram,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "cg"),
                                new AbbreviationsForCulture("ru-RU", "сг"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Decagram,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dag"),
                                new AbbreviationsForCulture("ru-RU", "даг"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Decigram,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dg"),
                                new AbbreviationsForCulture("ru-RU", "дг"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Gram,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "g"),
                                new AbbreviationsForCulture("ru-RU", "г"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Hectogram,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "hg"),
                                new AbbreviationsForCulture("ru-RU", "гг"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Kilogram,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kg"),
                                new AbbreviationsForCulture("ru-RU", "кг"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Kilotonne,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kt"),
                                new AbbreviationsForCulture("ru-RU", "кт"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.LongTon,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "long tn"),
                                new AbbreviationsForCulture("ru-RU", "тонна большая"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Megatonne,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Mt"),
                                new AbbreviationsForCulture("ru-RU", "Мт"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Microgram,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "μg"),
                                new AbbreviationsForCulture("ru-RU", "мкг"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Milligram,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mg"),
                                new AbbreviationsForCulture("ru-RU", "мг"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Nanogram,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ng"),
                                new AbbreviationsForCulture("ru-RU", "нг"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Ounce,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "oz"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Pound,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lb"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.ShortTon,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "short tn"),
                                new AbbreviationsForCulture("ru-RU", "тонна малая"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Stone,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "st"),
                            }),
                        new CulturesForEnumValue((int) MassUnit.Tonne,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "t"),
                                new AbbreviationsForCulture("ru-RU", "т"),
                            }),
                    }),
                new UnitLocalization(typeof (PowerUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) PowerUnit.BoilerHorsepower,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "hp(S)"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.ElectricalHorsepower,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "hp(E)"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Femtowatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "fW"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Gigawatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "GW"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.HydraulicHorsepower,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "hp(H)"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Kilowatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kW"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.MechanicalHorsepower,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "hp(I)"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Megawatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MW"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.MetricHorsepower,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "hp(M)"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Microwatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "μW"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Milliwatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mW"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Nanowatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "nW"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Petawatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "PW"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Picowatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "pW"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Terawatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "TW"),
                            }),
                        new CulturesForEnumValue((int) PowerUnit.Watt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "W"),
                            }),
                    }),
                new UnitLocalization(typeof (PowerRatioUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) PowerRatioUnit.DecibelMilliwatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dBmW", "dBm"),
                            }),
                        new CulturesForEnumValue((int) PowerRatioUnit.DecibelWatt,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dBW"),
                            }),
                    }),
                new UnitLocalization(typeof (PressureUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) PressureUnit.Atmosphere,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "atm"),
                                new AbbreviationsForCulture("ru-RU", "атм"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Bar,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "bar"),
                                new AbbreviationsForCulture("ru-RU", "бар"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Centibar,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "cbar"),
                                new AbbreviationsForCulture("ru-RU", "cбар"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Decapascal,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "daPa"),
                                new AbbreviationsForCulture("ru-RU", "МПа"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Decibar,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dbar"),
                                new AbbreviationsForCulture("ru-RU", "dбар"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Gigapascal,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "GPa"),
                                new AbbreviationsForCulture("ru-RU", ""),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Hectopascal,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "hPa"),
                                new AbbreviationsForCulture("ru-RU", ""),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Kilobar,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kbar"),
                                new AbbreviationsForCulture("ru-RU", "kбар"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.KilogramForcePerSquareCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kgf/cm²"),
                                new AbbreviationsForCulture("ru-RU", "кгс/см²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.KilogramForcePerSquareMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kgf/m²"),
                                new AbbreviationsForCulture("ru-RU", "кгс/м²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.KilogramForcePerSquareMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kgf/mm²"),
                                new AbbreviationsForCulture("ru-RU", "кгс/мм²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.KilonewtonPerSquareCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kN/cm²"),
                                new AbbreviationsForCulture("ru-RU", ""),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.KilonewtonPerSquareMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kN/m²"),
                                new AbbreviationsForCulture("ru-RU", ""),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.KilonewtonPerSquareMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kN/mm²"),
                                new AbbreviationsForCulture("ru-RU", ""),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Kilopascal,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kPa"),
                                new AbbreviationsForCulture("ru-RU", ""),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.KilopoundForcePerSquareFoot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kipf/ft²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.KilopoundForcePerSquareInch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kipf/in²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Megabar,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Mbar"),
                                new AbbreviationsForCulture("ru-RU", "Mбар"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Megapascal,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "MPa"),
                                new AbbreviationsForCulture("ru-RU", ""),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Micropascal,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "μPa"),
                                new AbbreviationsForCulture("ru-RU", "кПа"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Millibar,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mbar"),
                                new AbbreviationsForCulture("ru-RU", "mбар"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.NewtonPerSquareCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "N/cm²"),
                                new AbbreviationsForCulture("ru-RU", "Н/см²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.NewtonPerSquareMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "N/m²"),
                                new AbbreviationsForCulture("ru-RU", "Н/м²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.NewtonPerSquareMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "N/mm²"),
                                new AbbreviationsForCulture("ru-RU", "Н/мм²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Pascal,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Pa"),
                                new AbbreviationsForCulture("ru-RU", "Па"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.PoundForcePerSquareFoot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lb/ft²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.PoundForcePerSquareInch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lb/in²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Psi,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "psi"),
                                new AbbreviationsForCulture("ru-RU", "psi"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.TechnicalAtmosphere,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "at"),
                                new AbbreviationsForCulture("ru-RU", "ат"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.TonneForcePerSquareCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "tf/cm²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.TonneForcePerSquareMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "tf/m²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.TonneForcePerSquareMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "tf/mm²"),
                            }),
                        new CulturesForEnumValue((int) PressureUnit.Torr,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "torr"),
                                new AbbreviationsForCulture("ru-RU", "торр"),
                            }),
                    }),
                new UnitLocalization(typeof (RatioUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) RatioUnit.DecimalFraction,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", ""),
                            }),
                        new CulturesForEnumValue((int) RatioUnit.PartPerBillion,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ppb"),
                            }),
                        new CulturesForEnumValue((int) RatioUnit.PartPerMillion,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ppm"),
                            }),
                        new CulturesForEnumValue((int) RatioUnit.PartPerThousand,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "‰"),
                            }),
                        new CulturesForEnumValue((int) RatioUnit.PartPerTrillion,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ppt"),
                            }),
                        new CulturesForEnumValue((int) RatioUnit.Percent,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "%"),
                            }),
                    }),
                new UnitLocalization(typeof (RotationalSpeedUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) RotationalSpeedUnit.RevolutionPerMinute,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "rpm", "r/min"),
                                new AbbreviationsForCulture("ru-RU", "об/мин"),
                            }),
                        new CulturesForEnumValue((int) RotationalSpeedUnit.RevolutionPerSecond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "r/s"),
                                new AbbreviationsForCulture("ru-RU", "об/с"),
                            }),
                    }),
                new UnitLocalization(typeof (SpecificWeightUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) SpecificWeightUnit.KilogramForcePerCubicCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kgf/cmÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.KilogramForcePerCubicMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kgf/mÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.KilogramForcePerCubicMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kgf/mmÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.KilonewtonPerCubicCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kN/cmÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.KilonewtonPerCubicMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kN/mÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.KilonewtonPerCubicMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kN/mmÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.KilopoundForcePerCubicFoot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kipf/ftÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.KilopoundForcePerCubicInch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kipf/inÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.NewtonPerCubicCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "N/cmÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.NewtonPerCubicMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "N/mÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.NewtonPerCubicMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "N/mmÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.PoundForcePerCubicFoot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lbf/ftÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.PoundForcePerCubicInch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lbf/inÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.TonneForcePerCubicCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "tf/cmÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.TonneForcePerCubicMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "tf/mÂ³"),
                            }),
                        new CulturesForEnumValue((int) SpecificWeightUnit.TonneForcePerCubicMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "tf/mmÂ³"),
                            }),
                    }),
                new UnitLocalization(typeof (SpeedUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) SpeedUnit.FootPerSecond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ft/s"),
                            }),
                        new CulturesForEnumValue((int) SpeedUnit.KilometerPerHour,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "km/h", "kph"),
                            }),
                        new CulturesForEnumValue((int) SpeedUnit.Knot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kt", "kn", "knot", "knots"),
                            }),
                        new CulturesForEnumValue((int) SpeedUnit.MeterPerSecond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "m/s"),
                            }),
                        new CulturesForEnumValue((int) SpeedUnit.MilePerHour,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mph"),
                            }),
                        new CulturesForEnumValue((int) SpeedUnit.MillimeterPerSecond,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mm/s"),
                            }),
                    }),
                new UnitLocalization(typeof (TemperatureUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) TemperatureUnit.DegreeCelsius,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "°C"),
                            }),
                        new CulturesForEnumValue((int) TemperatureUnit.DegreeDelisle,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "°De"),
                            }),
                        new CulturesForEnumValue((int) TemperatureUnit.DegreeFahrenheit,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "°F"),
                            }),
                        new CulturesForEnumValue((int) TemperatureUnit.DegreeNewton,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "°N"),
                            }),
                        new CulturesForEnumValue((int) TemperatureUnit.DegreeRankine,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "°R"),
                            }),
                        new CulturesForEnumValue((int) TemperatureUnit.DegreeReaumur,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "°Ré"),
                            }),
                        new CulturesForEnumValue((int) TemperatureUnit.DegreeRoemer,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "°Rø"),
                            }),
                        new CulturesForEnumValue((int) TemperatureUnit.Kelvin,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "K"),
                            }),
                    }),
                new UnitLocalization(typeof (TorqueUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) TorqueUnit.KilogramForceCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kgf·cm"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.KilogramForceMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kgf·m"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.KilogramForceMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kgf·mm"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.KilonewtonCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kN·cm"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.KilonewtonMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kN·m"),
                                new AbbreviationsForCulture("ru-RU", "кН·м"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.KilonewtonMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kN·mm"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.KilopoundForceFoot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kipf·ft"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.KilopoundForceInch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "kipf·in"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.NewtonCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "N·cm"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.NewtonMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "N·m"),
                                new AbbreviationsForCulture("ru-RU", "Н·м"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.NewtonMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "N·mm"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.PoundForceFoot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lbf·ft"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.PoundForceInch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "lbf·in"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.TonneForceCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "tf·cm"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.TonneForceMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "tf·m"),
                            }),
                        new CulturesForEnumValue((int) TorqueUnit.TonneForceMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "tf·mm"),
                            }),
                    }),
                new UnitLocalization(typeof (VolumeUnit),
                    new[]
                    {
                        new CulturesForEnumValue((int) VolumeUnit.Centiliter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "cl"),
                                new AbbreviationsForCulture("ru-RU", "сл"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.CubicCentimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "cm³"),
                                new AbbreviationsForCulture("ru-RU", "см³"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.CubicDecimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dm³"),
                                new AbbreviationsForCulture("ru-RU", "дм³"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.CubicFoot,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ft³"),
                                new AbbreviationsForCulture("ru-RU", "фут³"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.CubicInch,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "in³"),
                                new AbbreviationsForCulture("ru-RU", "дюйм³"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.CubicKilometer,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "km³"),
                                new AbbreviationsForCulture("ru-RU", "км³"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.CubicMeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "m³"),
                                new AbbreviationsForCulture("ru-RU", "м³"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.CubicMile,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mi³"),
                                new AbbreviationsForCulture("ru-RU", "миля³"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.CubicMillimeter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "mm³"),
                                new AbbreviationsForCulture("ru-RU", "мм³"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.CubicYard,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "yd³"),
                                new AbbreviationsForCulture("ru-RU", "ярд³"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.Deciliter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "dl"),
                                new AbbreviationsForCulture("ru-RU", "дл"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.Hectoliter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "hl"),
                                new AbbreviationsForCulture("ru-RU", "гл"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.ImperialGallon,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "gal (imp.)"),
                                new AbbreviationsForCulture("ru-RU", "Английский галлон"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.ImperialOunce,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "oz (imp.)"),
                                new AbbreviationsForCulture("ru-RU", "Английская унция"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.Liter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "l"),
                                new AbbreviationsForCulture("ru-RU", "л"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.Milliliter,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "ml"),
                                new AbbreviationsForCulture("ru-RU", "мл"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.Tablespoon,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "Tbsp", "Tbs", "T", "tb", "tbs", "tbsp", "tblsp", "tblspn", "Tbsp.", "Tbs.", "T.", "tb.", "tbs.", "tbsp.", "tblsp.", "tblspn.", "tablespoon", "Tablespoon"),
                                new AbbreviationsForCulture("ru-RU", "столовая ложка"),
                                new AbbreviationsForCulture("nb-NO", "ss", "ss.", "SS", "SS."),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.Teaspoon,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "tsp", "t", "ts", "tspn", "t.", "ts.", "tsp.", "tspn.", "teaspoon"),
                                new AbbreviationsForCulture("ru-RU", "чайная ложка"),
                                new AbbreviationsForCulture("nb-NO", "ts", "ts."),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.UsGallon,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "gal (U.S.)"),
                                new AbbreviationsForCulture("ru-RU", "Американский галлон"),
                            }),
                        new CulturesForEnumValue((int) VolumeUnit.UsOunce,
                            new[]
                            {
                                new AbbreviationsForCulture("en-US", "oz (U.S.)"),
                                new AbbreviationsForCulture("ru-RU", "Американская унция"),
                            }),
                    }),
             });
    }
}

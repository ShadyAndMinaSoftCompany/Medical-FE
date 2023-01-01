using BackendCore.Common.Core;
using BackendCore.Common.DTO.Business.DeviceBrand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCore.Common.DTO.Business.ModelDetail
{
    public class AddModelDetailDto : IEntityDto<Guid?>
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Screen_Size { get; set; }
        public int? Screen_Size_Points { get; set; }
        public string Screen_Size_Type { get; set; }
        public string Resolution { get; set; }
        public int? Resolution_Points { get; set; }
        public string Resolution_Type { get; set; }
        public string Weight { get; set; }
        public int? Weight_Points { get; set; }
        public string Weight_Type { get; set; }
        public bool MaitainNominalTemp { get; set; }
        public int? MaitainNominalTemp_Points { get; set; }
        public string MaitainNominalTemp_Type { get; set; }
        public bool Noise50dB { get; set; }
        public int? Noise50dB_Points { get; set; }
        public string Noise50dB_Type { get; set; }
        public bool CaseHardSplashProof { get; set; }
        public int? CaseHardSplashProof_Points { get; set; }
        public string CaseHardSplashProof_Type { get; set; }

        public string Voltage { get; set; }
        public int? Voltage_Points { get; set; }
        public string Voltage_Type { get; set; }

        public string Frequency { get; set; }
        public int? Frequency_Points { get; set; }
        public string Frequency_Type { get; set; }


        public string BatteryType { get; set; }
        public int? BatteryType_Points { get; set; }
        public string BatteryType_Type { get; set; }

        public string BatteryBackup { get; set; }
        public int? BatteryBackup_Points { get; set; }
        public string BatteryBackup_Type { get; set; }

        public string BatteryChargingTime { get; set; }
        public int? BatteryChargingTime_Points { get; set; }
        public string BatteryChargingTime_Type { get; set; }

        public string PowerConsumption { get; set; }
        public int? PowerConsumption_Points { get; set; }
        public string PowerConsumption_Type { get; set; }

        public bool ElectricalProtection { get; set; }
        public int? ElectricalProtection_Points { get; set; }
        public string ElectricalProtection_Type { get; set; }

        public string CapableOfSavingData { get; set; }
        public int? CapableOfSavingData_Points { get; set; }
        public string CapableOfSavingData_Type { get; set; }

        public string LeadsECGCable { get; set; }
        public int? LeadsECGCable_Points { get; set; }
        public string LeadsECGCable_Type { get; set; }

        public string RespirationRange { get; set; }
        public int? RespirationRange_Points { get; set; }
        public string RespirationRange_Type { get; set; }

        public string ECGHeartRateRange { get; set; }
        public int? ECGHeartRateRange_Points { get; set; }
        public string ECGHeartRateRange_Type { get; set; }

        public string IBPMeasuringRange { get; set; }
        public int? IBPMeasuringRange_Points { get; set; }
        public string IBPMeasuringRange_Type { get; set; }

        public string NIBPDisplayedParameters { get; set; }
        public int? NIBPDisplayedParameters_Points { get; set; }
        public string NIBPDisplayedParameters_Type { get; set; }

        public string NIBPHeartRateMeasuringRange { get; set; }
        public int? NIBPHeartRateMeasuringRange_Points { get; set; }
        public string NIBPHeartRateMeasuringRange_Type { get; set; }

        public string SpO2MeasuringRange { get; set; }
        public int? SpO2MeasuringRange_Points { get; set; }
        public string SpO2MeasuringRange_Type { get; set; }

        public string SpO2PulseMeasuringRange { get; set; }
        public int? SpO2PulseMeasuringRange_Points { get; set; }
        public string SpO2PulseMeasuringRange_Type { get; set; }

        public string RecorderType { get; set; }
        public int? RecorderType_Points { get; set; }
        public string RecorderType_Type { get; set; }

        public string RecordingRate { get; set; }
        public int? RecordingRate_Points { get; set; }
        public string RecordingRate_Type { get; set; }

        public string RecordedWaveforms { get; set; }
        public int? RecordedWaveforms_Points { get; set; }
        public string RecordedWaveforms_Type { get; set; }

        public string CO2MeasurementTechnique { get; set; }
        public int? CO2MeasurementTechnique_Points { get; set; }
        public string CO2MeasurementTechnique_Type { get; set; }

        public string CO2MeasurementRange { get; set; }
        public int? CO2MeasurementRange_Points { get; set; }
        public string CO2MeasurementRange_Type { get; set; }


        public string AGMeasurementTechnique { get; set; }
        public int? AGMeasurementTechnique_Points { get; set; }
        public string AGMeasurementTechnique_Type { get; set; }

        public string TempMeasurementRange { get; set; }
        public int? TempMeasurementRange_Points { get; set; }
        public string TempMeasurementRange_Type { get; set; }

        public string IBPMeasurementIntervalInAutoMode { get; set; }
        public int? IBPMeasurementIntervalInAutoMode_Points { get; set; }
        public string IBPMeasurementIntervalInAutoMode_Type { get; set; }

        public string TraceRecorder { get; set; }
        public int? TraceRecorder_Points { get; set; }
        public string TraceRecorder_Type { get; set; }

        public string AlarmEvents { get; set; }
        public int? AlarmEvents_Points { get; set; }
        public string AlarmEvents_Type { get; set; }

        public string NIBPListingInclude { get; set; }
        public int? NIBPListingInclude_Points { get; set; }
        public string NIBPListingInclude_Type { get; set; }

        public string RangeOFPacemakerDetection { get; set; }
        public int? RangeOFPacemakerDetection_Points { get; set; }
        public string RangeOFPacemakerDetection_Type { get; set; }
        public string Features { get; set; }
        public Guid? DeviceBrandId { get; set; }
        public AddDeviceBrandDto DeviceBrand { get; set; }
    }
}

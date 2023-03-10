// <auto-generated />
using System;
using BackendCore.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendCore.Data.Migrations
{
    [DbContext(typeof(BackendCoreDbContext))]
    [Migration("20221227092823_RemoveDepartmentDevicesEntity")]
    partial class RemoveDepartmentDevicesEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BackendCore.Entities.Entities.Audit.Audit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AffectedColumns")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuditTrails");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Business.Attachment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AttachmentDisplaySize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Business.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bidder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryOfOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Business.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Business.DeviceBrand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeviceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("DeviceId");

                    b.ToTable("DeviceBrands");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Business.ModelDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AGMeasurementTechnique")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AGMeasurementTechnique_Points")
                        .HasColumnType("int");

                    b.Property<string>("AGMeasurementTechnique_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlarmEvents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AlarmEvents_Points")
                        .HasColumnType("int");

                    b.Property<string>("AlarmEvents_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatteryBackup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BatteryBackup_Points")
                        .HasColumnType("int");

                    b.Property<string>("BatteryBackup_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatteryChargingTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BatteryChargingTime_Points")
                        .HasColumnType("int");

                    b.Property<string>("BatteryChargingTime_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatteryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BatteryType_Points")
                        .HasColumnType("int");

                    b.Property<string>("BatteryType_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CO2MeasurementRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CO2MeasurementRange_Points")
                        .HasColumnType("int");

                    b.Property<string>("CO2MeasurementRange_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CO2MeasurementTechnique")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CO2MeasurementTechnique_Points")
                        .HasColumnType("int");

                    b.Property<string>("CO2MeasurementTechnique_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CapableOfSavingData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CapableOfSavingData_Points")
                        .HasColumnType("int");

                    b.Property<string>("CapableOfSavingData_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CaseHardSplashProof")
                        .HasColumnType("bit");

                    b.Property<int?>("CaseHardSplashProof_Points")
                        .HasColumnType("int");

                    b.Property<string>("CaseHardSplashProof_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ECGHeartRateRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ECGHeartRateRange_Points")
                        .HasColumnType("int");

                    b.Property<string>("ECGHeartRateRange_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ElectricalProtection")
                        .HasColumnType("bit");

                    b.Property<int?>("ElectricalProtection_Points")
                        .HasColumnType("int");

                    b.Property<string>("ElectricalProtection_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Features")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Frequency_Points")
                        .HasColumnType("int");

                    b.Property<string>("Frequency_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IBPMeasurementIntervalInAutoMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IBPMeasurementIntervalInAutoMode_Points")
                        .HasColumnType("int");

                    b.Property<string>("IBPMeasurementIntervalInAutoMode_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IBPMeasuringRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IBPMeasuringRange_Points")
                        .HasColumnType("int");

                    b.Property<string>("IBPMeasuringRange_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LeadsECGCable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LeadsECGCable_Points")
                        .HasColumnType("int");

                    b.Property<string>("LeadsECGCable_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MaitainNominalTemp")
                        .HasColumnType("bit");

                    b.Property<int?>("MaitainNominalTemp_Points")
                        .HasColumnType("int");

                    b.Property<string>("MaitainNominalTemp_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NIBPDisplayedParameters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NIBPDisplayedParameters_Points")
                        .HasColumnType("int");

                    b.Property<string>("NIBPDisplayedParameters_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIBPHeartRateMeasuringRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NIBPHeartRateMeasuringRange_Points")
                        .HasColumnType("int");

                    b.Property<string>("NIBPHeartRateMeasuringRange_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIBPListingInclude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NIBPListingInclude_Points")
                        .HasColumnType("int");

                    b.Property<string>("NIBPListingInclude_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Noise50dB")
                        .HasColumnType("bit");

                    b.Property<int?>("Noise50dB_Points")
                        .HasColumnType("int");

                    b.Property<string>("Noise50dB_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerConsumption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PowerConsumption_Points")
                        .HasColumnType("int");

                    b.Property<string>("PowerConsumption_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RangeOFPacemakerDetection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RangeOFPacemakerDetection_Points")
                        .HasColumnType("int");

                    b.Property<string>("RangeOFPacemakerDetection_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordedWaveforms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecordedWaveforms_Points")
                        .HasColumnType("int");

                    b.Property<string>("RecordedWaveforms_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecorderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecorderType_Points")
                        .HasColumnType("int");

                    b.Property<string>("RecorderType_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordingRate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecordingRate_Points")
                        .HasColumnType("int");

                    b.Property<string>("RecordingRate_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Resolution_Points")
                        .HasColumnType("int");

                    b.Property<string>("Resolution_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RespirationRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RespirationRange_Points")
                        .HasColumnType("int");

                    b.Property<string>("RespirationRange_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Screen_Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Screen_Size_Points")
                        .HasColumnType("int");

                    b.Property<string>("Screen_Size_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpO2MeasuringRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpO2MeasuringRange_Points")
                        .HasColumnType("int");

                    b.Property<string>("SpO2MeasuringRange_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpO2PulseMeasuringRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpO2PulseMeasuringRange_Points")
                        .HasColumnType("int");

                    b.Property<string>("SpO2PulseMeasuringRange_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempMeasurementRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TempMeasurementRange_Points")
                        .HasColumnType("int");

                    b.Property<string>("TempMeasurementRange_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraceRecorder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TraceRecorder_Points")
                        .HasColumnType("int");

                    b.Property<string>("TraceRecorder_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voltage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Voltage_Points")
                        .HasColumnType("int");

                    b.Property<string>("Voltage_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Weight_Points")
                        .HasColumnType("int");

                    b.Property<string>("Weight_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("ModelDetails");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Common.File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AppCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StorageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.LoginHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthenticationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoginHistories");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.RolePermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ShopId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                            CreatedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Admin@admin.com",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Admin",
                            PasswordHash = "AEyzbTVlNfDWtY6l8SokhviusJU36nh2gASHsKAaR/iFh7aV/OPHeekGyDGHz/v2cA==",
                            Phone = "01016670280",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Lookup.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Business.Device", b =>
                {
                    b.HasOne("BackendCore.Entities.Entities.Lookup.Department", "Department")
                        .WithMany("Devices")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Business.DeviceBrand", b =>
                {
                    b.HasOne("BackendCore.Entities.Entities.Business.Brand", "Brand")
                        .WithMany("DeviceBrands")
                        .HasForeignKey("BrandId");

                    b.HasOne("BackendCore.Entities.Entities.Business.Device", "Device")
                        .WithMany("DeviceBrands")
                        .HasForeignKey("DeviceId");

                    b.Navigation("Brand");

                    b.Navigation("Device");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Business.ModelDetail", b =>
                {
                    b.HasOne("BackendCore.Entities.Entities.Business.Brand", "Brand")
                        .WithMany("ModelDetails")
                        .HasForeignKey("BrandId");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.RolePermission", b =>
                {
                    b.HasOne("BackendCore.Entities.Entities.Identity.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendCore.Entities.Entities.Identity.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.UserRole", b =>
                {
                    b.HasOne("BackendCore.Entities.Entities.Identity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackendCore.Entities.Entities.Identity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Business.Brand", b =>
                {
                    b.Navigation("DeviceBrands");

                    b.Navigation("ModelDetails");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Business.Device", b =>
                {
                    b.Navigation("DeviceBrands");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Identity.User", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("BackendCore.Entities.Entities.Lookup.Department", b =>
                {
                    b.Navigation("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}

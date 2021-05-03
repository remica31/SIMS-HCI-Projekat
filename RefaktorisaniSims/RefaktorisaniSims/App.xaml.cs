﻿
using Controller;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RefaktorisaniSims
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public readonly AppointmentController appointmentController = new AppointmentController();
        public readonly PatientController patientController = new PatientController();
        public readonly DoctorController doctorController = new DoctorController();
        public readonly OperationController operationController = new OperationController();
        public readonly MedicineController medicineController = new MedicineController();
        public readonly ReceiptController receiptController = new ReceiptController();
        public readonly AnamnesisController anamnesisController = new AnamnesisController();
        public readonly HolidayRequestController holidayRequestController = new HolidayRequestController();
        public readonly DynamicEquipmentRequestController dynamicEquipmentRequestController = new DynamicEquipmentRequestController();
        public readonly AvailableAppointmentController availableAppointmentController = new AvailableAppointmentController();
        public readonly GuestController guestController = new GuestController();
        public readonly AllergenController allergenController = new AllergenController();
        public readonly MedicineNotificationController medicineNotificationController = new MedicineNotificationController();
        public readonly AppointmentNotificationController appointmentNotificationController = new AppointmentNotificationController();
        public readonly DynamicEquipmentController dynamicEquipmentController = new DynamicEquipmentController();
        public readonly StaticEquipmentController staticEquipmentController = new StaticEquipmentController();
        public readonly RoomController roomController = new RoomController();
        public readonly StaticTransferScheduleController staticTransferScheduleController = new StaticTransferScheduleController();
        public readonly HospitalReferralController hospitalReferralController = new HospitalReferralController();
        public readonly SurveyController surveyController = new SurveyController();
        public int counterCancel = 0;
        public string id;


    }
}

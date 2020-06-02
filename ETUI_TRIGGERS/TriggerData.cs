 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ETUI_TRIGGERS
{
    [Serializable()]
    public class TriggerData : ISerializable
    {
        //------------------Properties---------------------------------------------------------        
        public int OperationType { get; set; }
        public int OperationAction { get; set; }
        public int OperationKey { get; set; }
        public int OperationKeyEvent { get; set; }
        public string OperationApplicationPath { get; set; }
        public string OperationPowerShellCommand { get; set; }
        public int TriggerType { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int SizeWidth { get; set; }
        public int SizeHeight { get; set; }
        public float TimeDelayInSeconds { get; set; }

        //-------------------Constructors--------------------------------------------------------
        public TriggerData() { }
        public TriggerData(int operationType, int operationAction, int operationKey, int operationKeyEvent, string operationApplicationPath, string operationPowerShellCommand, int triggerType, int locationX, int locationY, int sizeWidth, int sizeHeight, float timeDelayInSeconds)
        {
            OperationType = operationType;
            OperationAction = operationAction;
            OperationKey = operationKey;
            OperationKeyEvent = operationKeyEvent;
            OperationApplicationPath = operationApplicationPath;
            OperationPowerShellCommand = operationPowerShellCommand;
            TriggerType = triggerType;
            LocationX = locationX;
            LocationY = locationY;
            SizeWidth = sizeWidth;
            SizeHeight = sizeHeight;
            TimeDelayInSeconds = timeDelayInSeconds;
        }
        public TriggerData(SerializationInfo info, StreamingContext context)
        {
            OperationType = (int)info.GetValue("Type", typeof(int));
            OperationAction = (int)info.GetValue("Action", typeof(int));
            OperationKey = (int)info.GetValue("Key", typeof(int));
            OperationKeyEvent = (int)info.GetValue("KeyEvent", typeof(int));
            OperationApplicationPath = (string)info.GetValue("ApplicationPath", typeof(string));
            OperationPowerShellCommand = (string)info.GetValue("PowerShellCommand", typeof(string));
            TriggerType = (int)info.GetValue("TriggerType", typeof(int));
            LocationX = (int)info.GetValue("LocationX", typeof(int));
            LocationY = (int)info.GetValue("LocationY", typeof(int));
            SizeWidth = (int)info.GetValue("SizeWidth", typeof(int));
            SizeHeight = (int)info.GetValue("SizeHeight", typeof(int));
            TimeDelayInSeconds = (float)info.GetValue("TimeDelayInSeconds", typeof(float));

        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Type", OperationType);
            info.AddValue("Action", OperationAction);
            info.AddValue("Key", OperationKey);
            info.AddValue("KeyEvent", OperationKeyEvent);
            info.AddValue("ApplicationPath", OperationApplicationPath);
            info.AddValue("PowerShellCommand", OperationPowerShellCommand);
            info.AddValue("TriggerType", TriggerType);
            info.AddValue("LocationX", LocationX);
            info.AddValue("LocationY", LocationY);
            info.AddValue("SizeWidth", SizeWidth);
            info.AddValue("SizeHeight", SizeHeight);
            info.AddValue("TimeDelayInSeconds", TimeDelayInSeconds);
        }

        public void PrintProperties()
        {
            Console.WriteLine();
            Console.Write($"Type {OperationType} | Action {OperationAction} | Key {OperationKey} | KeyEvent {OperationKeyEvent} | Application Path {OperationApplicationPath} | PowerShellCommand {OperationPowerShellCommand} | TriggerType {TriggerType} | LocationX {LocationX} | LocationY {LocationY} | SizeWidth {SizeWidth} | SizeHeight {SizeHeight} | TimeDelayInSeconds {TimeDelayInSeconds}");
        }
    }
}

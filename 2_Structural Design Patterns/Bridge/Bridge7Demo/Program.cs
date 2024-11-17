using Bridge7Demo._1_Define_Implementor_Interface;
using Bridge7Demo._2_Create_Concrete_Implementations;
using Bridge7Demo._3_Define_Abstraction;
using Bridge7Demo._4_Create_Refined_Abstraction;

IDevice tv = new Tv();
IDevice radio = new Radio();

RemoteControl basicRemote =new BasicRemote(tv);
basicRemote.TurnOn();
radio.SetVolume(22);

RemoteControl advancedRemote = new AdvancedRemote(tv);
advancedRemote.TurnOn();
((AdvancedRemote)advancedRemote).Mute();
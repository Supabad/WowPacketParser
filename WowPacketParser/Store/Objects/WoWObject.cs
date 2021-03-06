using System.Collections.Generic;
using WowPacketParser.Enums;
using WowPacketParser.Misc;

namespace WowPacketParser.Store.Objects
{
    public class WoWObject
    {
        public Vector3 GetPosition()
        {
            return Movement.Position;
        }

        public ObjectType Type;

        public MovementInfo Movement;

        public uint Map;

        public Dictionary<int, UpdateField> UpdateFields; // SMSG_UPDATE_OBJECT - CreateObject

        public Dictionary<int, UpdateField> ChangedUpdateFields; // SMSG_UPDATE_OBJECT - Values
    }
}

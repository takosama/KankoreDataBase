using System;
using System.Collections.Generic;
using System.Linq;
using JsDataParser.DataLoader;
using JsDataParser.Entities;

namespace KankoreDataBase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            KcDataBase.Init();
            var s=new Ship(1);
            var s0=new Ship(10);
            s.Items=new Item[]{new Item(3), new Item(1), new Item(2) };
            s0.Items= new Item[] { new Item(3), new Item(1), new Item(2) };
            var p=new AttackPropertys();
            var p0=new AttackPropertys();
            p0.IsMyFleet = false;
            p.type=CombiedFleet.CombiedFleetType.Air;
            p0.type=CombiedFleet.CombiedFleetType.Air;
            ShellAttack.Attack(s,s0,p,p0);
        }
    }

   

    public static class ShellAttack
    {
        /// <summary>
        /// 改修未対応
        /// </summary>
        /// <param name="attacker"></param>
        /// <param name="defender"></param>
        /// <param name="attackoption"></param>
        /// <param name="defenceoption"></param>
        /// <returns></returns>
        static public Ship Attack(Ship attacker, Ship defender,AttackPropertys attackoption, AttackPropertys defenceoption)
        {
        int attackerPow=  (int)  attacker.GetStatus(ShipParameter.Pow);
            //改修
            int CombiedCorrction = CombiedFleet.GetCorrection(attackoption);
            int basePow = attackerPow + CombiedCorrction;

            throw new Exception();
        }
    }

    public static class Attack
    {
        public static int GetFinalPower(AttackPropertys p)
        {
            
        }
    }



    public class Form
    {
        public enum Type
        {
            Same,
            Anti,
            Tadvance,
            Tdisadvance,
        }

        public static double Correction(Type t)
        {
            if (t == Type.Same)
                return 1;
            if (t == Type.Anti)
                return .8;
            if (t == Type.Tadvance)
                return 1.2;
            if (t == Type.Tdisadvance)
                return .6;
            throw  new Exception();
        }
    }
    public class AttackPropertys
    {
        public bool IsCombied = false;
        public bool IsMyFleet = true;
        public bool IsFleet1 = true;
        public CombiedFleet.CombiedFleetType type=CombiedFleet.CombiedFleetType.Air;
    }

    public static class CombiedFleet
    {
        public enum CombiedFleetType
        {
            Air,
            Water,
            Transport
        }

        public static int GetCorrection(AttackPropertys p)
        {
            int[] myFleet1 = {2, 10, -5};
            int[] myFleet2 = {10, -5, 10};
            int[] enFleet1 = {10, 5, 10};
            int[] enFleet2 = {5, -5, 5};
            int[] tmp = null;
            if (p.IsMyFleet)
            {
                if (p.IsFleet1)
                    tmp = myFleet1;
                else
                    tmp = myFleet2;
            }
            else
            {
                if (p.IsFleet1)
                    tmp = enFleet1;
                else
                    tmp = enFleet2;
            }
            return tmp[(int) p.type];
        }
    }


    public enum ItemTypeNames
    {
        MAINGUNS,
        MAINGUNSAA,
        MAINGUNM,
        MAINGUNL,
        MAINGUNXL,
        SECGUN,
        SECGUNAA,
        APSHELL,
        TORPEDO,
        TORPEDOSS,
        MIDGETSUB,
        AAGUN,
        AAFD,
        SONARS,
        SONARL,
        DEPTHCHARGE,
        FIGHTER,
        TORPBOMBER,
        DIVEBOMBER,
        SEAPLANE,
        SEAPLANEBOMBER,
        CARRIERSCOUT,
        CARRIERSCOUT2,
        AUTOGYRO,
        ASWPLANE,
        RADARS,
        RADARL,
        RADARXL,
        ENGINE,
        TYPE3SHELL,
        BULGEM,
        BULGEL,
        LANDINGCRAFT,
        SEARCHLIGHTS,
        SEARCHLIGHTL,
        STARSHELL,
        PICKET,
        WG42,
        SRF,
        FCF,
        DRUM,
        SCAMP,
        FLYINGBOAT,
        REPAIR,
        RATION,
        SEAPLANEFIGHTER,
        LANDINGTANK,
        OILDRUM,
        LANDBOMBER,
        INTERCEPTOR,
        TRANSPORTITEM,
        SUBRADAR,
        JETBOMBER,
        OTHER
    }

    public class ItemTypeData
    {
        public ItemTypeNames TypeName;
        public string name { get; set; }
        public int image { get; set; }
        public bool isPlane { get; set; }
        public bool isfighter { get; set; }
        public bool canContact { get; set; }
        public bool istorpbomber { get; set; }
        public bool isdivebomber { get; set; }
    }

    public class ItemTypeManager
    {
        public ItemTypeData GetItemTypeData(ItemTypeNames name)
        {
            var tmp = _data.First(x => (string) x.i.Index.Object == name.ToString());
            var _ = tmp.o.Keys.Zip(tmp.o.Values, (x, y) => (key:x, val: y)).ToArray();
            var rtn = new ItemTypeData();
            var p = rtn.GetType().GetProperties();
            foreach (var o in _)
            {
                var pname = (string) o.key.Object;
                foreach (var property in p)
                    if (property.Name == pname)
                        property.SetValue(rtn, o.val.Object);
            }
            rtn.TypeName = name;
            return rtn;
        }

        private readonly (IndexedIdentiferEntity i, ObjectLiteralEntity o)[] _data;

        public ItemTypeManager((IndexedIdentiferEntity i, ObjectLiteralEntity o)[] data)
        {
            _data = data;
        }

        public string GetItemTypeEnumStr()
        {
            var tmp = _data.Select(x => (string) x.i.Index.Object).ToArray();
            var str = "";
            foreach (var s in tmp)
                str += s + "\n";
            return str;
        }

        public string GetPropertysStr()
        {
            var tmp = _data.Select(x => x.o.Keys.Select(y => (string) y.Object)).ToList().ToList();
            var words = new List<string>();
            foreach (var list in tmp)
                words.AddRange(list);
            words = words.Distinct().ToList();
            var str = "";
            foreach (var s in words)
                str += s + "\n";
            return str;
        }
    }


    public static class KcDataBase
    {
        public static ObjectLiteralEntity KCShipData;
        public static ObjectLiteralEntity KCItemData;

        public static void Init()
        {
            var tmp = DataLoader.LoadRaw("ship.js");

            KCItemData = DataLoader.LoadRaw("itemData.js");
            KCShipData = tmp;
        }

        public static ValueEntity GetShipData(int ID)
        {
            var tmp = KCShipData.Values;

            foreach (var ship in tmp)
            foreach (var val in ship.NestedObject)
                if ((string) val.Key.Object == "nid")
                    if ((int) val.Value.Object == ID)
                        return ship;
                    else
                        continue;
            throw new Exception();
        }

        public static ValueEntity GetItemData(int ID)
        {
            try
            {
                var tmp = KCItemData.First(x => (int) x.Key.Object == ID).Value;
                return tmp;
            }
            catch
            {
                throw new Exception();
            }
        }
    }

    public enum ItemParameter
    {
        Pow,
    }


    public enum ShipParameter
    {
        MaxHP,
        HP,
        Name,
        SlotNums,
        Pow,
    }

    public class Item
    {
        public int ID;
        public int Level; //改修
        public int Skill; //熟練度
        private readonly ValueEntity data;

        public Item(int ID)
        {
            this.ID = ID;
            this.data = KcDataBase.GetItemData(this.ID);
        }

        public object GetStatus(ItemParameter p)
        {
            if (p == ItemParameter.Pow)
            {
                return  (int)data.NestedObject.First(x => (string)x.Key.Object == "FP").Value.Object;
            }
            //pow double
            throw new Exception();
        }
    }

    static class Renovation
    {
        public static double GetPowerK(Item i)
        {
            return 0;
        }
    }
    public class Ship
    {
        public int Id;
        public int Hp;
        public int NowHp;
        public Item[] Items;
        public int[] SlotNums;
        private readonly ValueEntity data;
        public string Name;

        public Ship(int ID)
        {
            Id = ID;
            data = KcDataBase.GetShipData(Id);
            Hp = (int) GetStatus(ShipParameter.HP);
            NowHp = Hp;
            SlotNums = (int[]) GetStatus(ShipParameter.SlotNums);
            Name = (string) GetStatus(ShipParameter.Name);
        }


        public object GetStatus(ShipParameter p)
        {
            if (p == ShipParameter.HP)
                return (int) data.NestedObject.First(x => (string) x.Key.Object == "HP").Value.Object;
            if (p == ShipParameter.SlotNums)
            {
                var tmp = data.NestedObject.First(x => (string) x.Key.Object == "SLOTS").Value.Array;
                return tmp.Select(x => x.Integer).ToArray();
            }
            if (p == ShipParameter.Name)
                return (string) data.NestedObject.First(x => (string) x.Key.Object == "nameJP").Value.Object;
            if (p == ShipParameter.Pow)
            {
                var basePow= (int)data.NestedObject.First(x => (string)x.Key.Object == "FP").Value.Object;
                return GetPower(basePow);
            }

            throw new Exception();
        }

        int GetPower(int BasePower)
        {
            var itemsPowSum = Items.Select(x => (int) x.GetStatus(ItemParameter.Pow)).Sum();
            return (int) (itemsPowSum + BasePower);
        }
    }
}
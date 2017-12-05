using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_VarList
{
    public class VarList
    {
        private List<string> _VarList;
        private int count= 0;

        public VarList()
        {
            _VarList = new List<string>();
        }

        public VarList(int count)
        {            
            this.count = count;
            _VarList = new List<string>();
        }

        #region Append部分
        public VarList Append(VarList args)
        {
            for (int i=0; i < args.Count(); ++i)
            {
                string ele = args.AtStringIndexOf(i);
                _VarList.Add(ele);
            }
            ++count;       
            return this;
        }

        public VarList Append(int value)
        {
            _VarList.Add(value.ToString());
            ++count;
            return this;
        }

        public VarList Append(bool value)
        {
            _VarList.Add(value.ToString());
            ++count;
            return this;
        }
        public VarList Append(float value)
        {
            _VarList.Add(value.ToString());
            ++count;
            return this;
        }

        public VarList Append(string value)
        {
            _VarList.Add(value);
            ++count;
            return this;
        }
        public VarList Append(byte value)
        {
            _VarList.Add(value.ToString());
            ++count;
            return this;
        }
        #endregion

        #region SubValue部分
        public int SubIntValue()
        {
            int value = 0;            
            value = int.Parse(_VarList[0]);
            _VarList.RemoveAt(0);
            --count;
            return value;
        }

        public bool SubBoolValue()
        {
            bool value = false;
            value = bool.Parse(_VarList[0]);
            _VarList.RemoveAt(0);
            --count;
            return value;
        }

        public byte SubByteValue()
        {
            byte value = 0;
            value = byte.Parse(_VarList[0]);
            _VarList.RemoveAt(0);
            --count;
            return value;
        }

        public float SubFloatValue()
        {
            float value = 0;
            value = float.Parse(_VarList[0]);
            _VarList.RemoveAt(0);
            --count;
            return value;
        }

        public string SubStringValue()
        {
            string value = string.Empty;
            value = _VarList[0];
            _VarList.RemoveAt(0);
            --count;
            return value;
        }
        
        public int SubIntValue(int index)
        {
            int value = 0;
            value = int.Parse(_VarList[index]);
            _VarList.RemoveAt(index);
            --count;
            return value;
        }

        public bool SubBoolValue(int index)
        {
            bool value = false;
            value = bool.Parse(_VarList[index]);
            _VarList.RemoveAt(index);
            --count;
            return value;
        }

        public byte SubByteValue(int index)
        {
            byte value = 0;
            value = byte.Parse(_VarList[index]);
            _VarList.RemoveAt(index);
            --count;
            return value;
        }

        public float SubFloatValue(int index)
        {
            float value = 0;
            value = float.Parse(_VarList[index]);
            _VarList.RemoveAt(index);
            --count;
            return value;
        }

        public string SubStringValue(int index)
        {
            string value = string.Empty;
            value = _VarList[index];
            _VarList.RemoveAt(index);
            --count;
            return value;
        }



        #endregion

        #region Index部分
        public int AtIntIndexOf()
        {
            int value = 0;
            value = int.Parse(_VarList[0]);            
            return value;
        }

        public bool AtBoolIndexOf()
        {
            bool value = false;
            value = bool.Parse(_VarList[0]);
            return value;
        }

        public float AtFloatIndexOf()
        {
            float value = 0;
            value = float.Parse(_VarList[0]);
            return value;
        }

        public string AtStringIndexOf()
        {
            string value = string.Empty;
            value = _VarList[0];
            return value;
        }

        public byte AtByteIndexOf()
        {
            byte value = 0;
            value = byte.Parse(_VarList[0]);
            return value;
        }

        

        public int AtIntIndexOf(int index)
        {
            int value = 0;
            value = int.Parse(_VarList[index]);
            return value;
        }

        public bool AtBoolIndexOf(int index)
        {
            bool value = false;
            value = bool.Parse(_VarList[index]);
            return value;
        }

        public float AtFloatIndexOf(int index)
        {
            float value = 0;
            value = float.Parse(_VarList[index]);
            return value;
        }

        public string AtStringIndexOf(int index)
        {
            string value = string.Empty;
            value = _VarList[index];
            return value;
        }

        public byte AtByteIndexOf(int index)
        {
            byte value = 0;
            value = byte.Parse(_VarList[index]);
            return value;
        }

        #endregion

        #region Set部分
        public void SetIntIndexOf(int value)
        {
            _VarList[0] = value.ToString();
        }

        public void SetStringIndexOf(string value)
        {
            _VarList[0] = value;
        }

        public void SetFloatInxOf(float value)
        {
            _VarList[0] = value.ToString();
        }

        public void SetIntIndexOf(int index,int value)
        {
            _VarList[index] = value.ToString();
        }

        public void SetStringIndexOf(int index,string value)
        {
            _VarList[index] = value;
        }

        public void SetFloatInxOf(int index,float value)
        {
            _VarList[index] = value.ToString();
        }

        public void SetBoolIndexOf(int index, bool value)
        {
            _VarList[index] = value.ToString();
        }

        #endregion

        #region 方法部分
        public void Clear()
        {
            _VarList.Clear();
        }

        /// <summary>
        /// 使VarList中的数据顺序反过来
        /// </summary>
        public void Revert()
        {
            List<string> Revert_VarList = new List<string>();

            for (int i = _VarList.Count -1; i >= 0; --i)
            {
                Revert_VarList.Add(_VarList[i]);
            }

            _VarList.Clear();
            _VarList = Revert_VarList;
        }

        public int Count()
        {
            int VarList_Count = 0;
            VarList_Count = _VarList.Count;
            return VarList_Count;
        }

        #endregion

        public override bool Equals(object obj)
        {          
            if (obj == this)
            {
                return true;
            }

            if (!(obj is VarList))
            {
                return false;
            }

            var varlist = (VarList)obj;
            return varlist._VarList.Count == _VarList.Count;
        }

        public override int GetHashCode()
        {
            string hash_code = string.Empty;
            for (int i = 0; i < _VarList.Count(); ++i)
            {
                hash_code += _VarList[i];
            }

            int hashcode = (hash_code).GetHashCode();

            return hashcode;
        }

    }
}

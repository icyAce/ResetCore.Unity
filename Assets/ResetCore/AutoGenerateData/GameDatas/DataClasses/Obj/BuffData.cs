// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ResetCore.Data.GameDatas.Obj
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;
    
    
    [System.SerializableAttribute()]
    public class BuffData : ObjData<BuffData>
    {
        
        public static String fileName = "BuffData";
        
        [UnityEngine.SerializeField()]
        private string _BuffName;
        
        [UnityEngine.SerializeField()]
        private float _BuffTime;
        
        public string BuffName
        {
            get
            {
                return this._BuffName;
            }
            set
            {
                this._BuffName = value;
            }
        }
        
        public float BuffTime
        {
            get
            {
                return this._BuffTime;
            }
            set
            {
                this._BuffTime = value;
            }
        }
    }
}
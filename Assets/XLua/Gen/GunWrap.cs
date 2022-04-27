#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class GunWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Gun);
			Utils.BeginObjectRegister(type, L, translator, 0, 11, 24, 24);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpGun", _m_UpGun);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DownGun", _m_DownGun);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GoldChange", _m_GoldChange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DiamandsChange", _m_DiamandsChange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanShootForFree", _m_CanShootForFree);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CantShootForFree", _m_CantShootForFree);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanGetDoubleGold", _m_CanGetDoubleGold);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CantGetDoubleGold", _m_CantGetDoubleGold);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CanShootNoCD", _m_CanShootNoCD);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CantShootNoCD", _m_CantShootNoCD);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BossAttack", _m_BossAttack);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "gold", _g_get_gold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "diamands", _g_get_diamands);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gunLevel", _g_get_gunLevel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "attackCD", _g_get_attackCD);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "level", _g_get_level);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bullectAudios", _g_get_bullectAudios);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "attackPos", _g_get_attackPos);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Bullects", _g_get_Bullects);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "net", _g_get_net);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gunChange", _g_get_gunChange);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "goldPlace", _g_get_goldPlace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "diamondsPlace", _g_get_diamondsPlace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "imageGoldPlace", _g_get_imageGoldPlace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "imageDiamandsPlace", _g_get_imageDiamandsPlace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "goldText", _g_get_goldText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "diamandsText", _g_get_diamandsText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canShootNoCD", _g_get_canShootNoCD);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "canChangeGun", _g_get_canChangeGun);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bossAttack", _g_get_bossAttack);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Fire", _g_get_Fire);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Ice", _g_get_Ice);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Butterfly", _g_get_Butterfly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "attack", _g_get_attack);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "changeAudio", _g_get_changeAudio);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "gold", _s_set_gold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "diamands", _s_set_diamands);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gunLevel", _s_set_gunLevel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "attackCD", _s_set_attackCD);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "level", _s_set_level);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bullectAudios", _s_set_bullectAudios);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "attackPos", _s_set_attackPos);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Bullects", _s_set_Bullects);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "net", _s_set_net);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gunChange", _s_set_gunChange);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "goldPlace", _s_set_goldPlace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "diamondsPlace", _s_set_diamondsPlace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "imageGoldPlace", _s_set_imageGoldPlace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "imageDiamandsPlace", _s_set_imageDiamandsPlace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "goldText", _s_set_goldText);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "diamandsText", _s_set_diamandsText);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "canShootNoCD", _s_set_canShootNoCD);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "canChangeGun", _s_set_canChangeGun);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bossAttack", _s_set_bossAttack);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Fire", _s_set_Fire);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Ice", _s_set_Ice);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Butterfly", _s_set_Butterfly);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "attack", _s_set_attack);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "changeAudio", _s_set_changeAudio);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Instance", _s_set_Instance);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new Gun();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Gun constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpGun(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.UpGun(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DownGun(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DownGun(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GoldChange(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _number = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.GoldChange( _number );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DiamandsChange(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _number = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.DiamandsChange( _number );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CanShootForFree(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CanShootForFree(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CantShootForFree(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CantShootForFree(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CanGetDoubleGold(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CanGetDoubleGold(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CantGetDoubleGold(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CantGetDoubleGold(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CanShootNoCD(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CanShootNoCD(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CantShootNoCD(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.CantShootNoCD(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BossAttack(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.BossAttack(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, Gun.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.gold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_diamands(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.diamands);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gunLevel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.gunLevel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_attackCD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.attackCD);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_level(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.level);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bullectAudios(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.bullectAudios);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_attackPos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.attackPos);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Bullects(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.Bullects);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_net(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.net);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gunChange(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gunChange);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_goldPlace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.goldPlace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_diamondsPlace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.diamondsPlace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_imageGoldPlace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.imageGoldPlace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_imageDiamandsPlace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.imageDiamandsPlace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_goldText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.goldText);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_diamandsText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.diamandsText);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canShootNoCD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canShootNoCD);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_canChangeGun(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.canChangeGun);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bossAttack(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.bossAttack);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Fire(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Fire);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Ice(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Ice);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Butterfly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.Butterfly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_attack(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.attack);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_changeAudio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.changeAudio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    Gun.Instance = (Gun)translator.GetObject(L, 1, typeof(Gun));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gold = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_diamands(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.diamands = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gunLevel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gunLevel = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_attackCD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.attackCD = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_level(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.level = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bullectAudios(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bullectAudios = (UnityEngine.AudioClip[])translator.GetObject(L, 2, typeof(UnityEngine.AudioClip[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_attackPos(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.attackPos = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Bullects(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Bullects = (UnityEngine.GameObject[])translator.GetObject(L, 2, typeof(UnityEngine.GameObject[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_net(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.net = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gunChange(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gunChange = (GunChange[])translator.GetObject(L, 2, typeof(GunChange[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_goldPlace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.goldPlace = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_diamondsPlace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.diamondsPlace = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_imageGoldPlace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.imageGoldPlace = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_imageDiamandsPlace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.imageDiamandsPlace = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_goldText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.goldText = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_diamandsText(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.diamandsText = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_canShootNoCD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.canShootNoCD = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_canChangeGun(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.canChangeGun = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bossAttack(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bossAttack = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Fire(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Fire = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Ice(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Ice = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Butterfly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Butterfly = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_attack(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.attack = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_changeAudio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Gun gen_to_be_invoked = (Gun)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.changeAudio = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

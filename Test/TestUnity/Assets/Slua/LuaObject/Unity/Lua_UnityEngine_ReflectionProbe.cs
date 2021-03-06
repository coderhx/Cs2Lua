﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ReflectionProbe : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe o;
			o=new UnityEngine.ReflectionProbe();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RenderProbe(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				var ret=self.RenderProbe();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				UnityEngine.RenderTexture a1;
				checkType(l,2,out a1);
				var ret=self.RenderProbe(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsFinishedRendering(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.IsFinishedRendering(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponent(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(string))){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetComponent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(System.Type))){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentInChildren(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentInChildren(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetComponentInChildren(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentsInChildren(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInChildren(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetComponentsInChildren(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentInParent(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			System.Type a1;
			checkType(l,2,out a1);
			var ret=self.GetComponentInParent(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponentsInParent(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponentsInParent(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				var ret=self.GetComponentsInParent(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetComponents(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				var ret=self.GetComponents(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.Type a1;
				checkType(l,2,out a1);
				System.Collections.Generic.List<UnityEngine.Component> a2;
				checkType(l,3,out a2);
				self.GetComponents(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompareTag(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.CompareTag(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SendMessageUpwards(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessageUpwards(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessageUpwards(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.SendMessageUpwards(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SendMessage(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SendMessage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.SendMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.SendMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.SendMessage(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BroadcastMessage(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.BroadcastMessage(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(UnityEngine.SendMessageOptions))){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				UnityEngine.SendMessageOptions a2;
				checkEnum(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(System.Object))){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				self.BroadcastMessage(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Object a2;
				checkType(l,3,out a2);
				UnityEngine.SendMessageOptions a3;
				checkEnum(l,4,out a3);
				self.BroadcastMessage(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInstanceID(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			var ret=self.GetInstanceID();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BlendCubemap_s(IntPtr l) {
		try {
			UnityEngine.Texture a1;
			checkType(l,1,out a1);
			UnityEngine.Texture a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.RenderTexture a4;
			checkType(l,4,out a4);
			var ret=UnityEngine.ReflectionProbe.BlendCubemap(a1,a2,a3,a4);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.type);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Rendering.ReflectionProbeType v;
			checkEnum(l,2,out v);
			self.type=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hdr(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hdr);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hdr(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.hdr=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.size);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.size=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.center);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.center=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_nearClipPlane(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nearClipPlane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_nearClipPlane(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.nearClipPlane=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_farClipPlane(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.farClipPlane);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_farClipPlane(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.farClipPlane=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shadowDistance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.shadowDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shadowDistance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.shadowDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_resolution(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.resolution);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_resolution(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.resolution=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullingMask(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cullingMask);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullingMask(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.cullingMask=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clearFlags(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.clearFlags);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clearFlags(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Rendering.ReflectionProbeClearFlags v;
			checkEnum(l,2,out v);
			self.clearFlags=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_backgroundColor(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.backgroundColor);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_backgroundColor(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.backgroundColor=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intensity(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.intensity);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_intensity(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.intensity=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blendDistance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.blendDistance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_blendDistance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.blendDistance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boxProjection(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.boxProjection);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boxProjection(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.boxProjection=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bounds(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bounds);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.mode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Rendering.ReflectionProbeMode v;
			checkEnum(l,2,out v);
			self.mode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_importance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.importance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_importance(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.importance=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_refreshMode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.refreshMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_refreshMode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Rendering.ReflectionProbeRefreshMode v;
			checkEnum(l,2,out v);
			self.refreshMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_timeSlicingMode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushEnum(l,(int)self.timeSlicingMode);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_timeSlicingMode(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Rendering.ReflectionProbeTimeSlicingMode v;
			checkEnum(l,2,out v);
			self.timeSlicingMode=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bakedTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.bakedTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bakedTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Texture v;
			checkType(l,2,out v);
			self.bakedTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_customBakedTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.customBakedTexture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_customBakedTexture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			UnityEngine.Texture v;
			checkType(l,2,out v);
			self.customBakedTexture=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_texture(IntPtr l) {
		try {
			UnityEngine.ReflectionProbe self=(UnityEngine.ReflectionProbe)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.texture);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ReflectionProbe");
		addMember(l,RenderProbe);
		addMember(l,IsFinishedRendering);
		addMember(l,GetComponent);
		addMember(l,GetComponentInChildren);
		addMember(l,GetComponentsInChildren);
		addMember(l,GetComponentInParent);
		addMember(l,GetComponentsInParent);
		addMember(l,GetComponents);
		addMember(l,CompareTag);
		addMember(l,SendMessageUpwards);
		addMember(l,SendMessage);
		addMember(l,BroadcastMessage);
		addMember(l,GetInstanceID);
		addMember(l,BlendCubemap_s);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"hdr",get_hdr,set_hdr,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"nearClipPlane",get_nearClipPlane,set_nearClipPlane,true);
		addMember(l,"farClipPlane",get_farClipPlane,set_farClipPlane,true);
		addMember(l,"shadowDistance",get_shadowDistance,set_shadowDistance,true);
		addMember(l,"resolution",get_resolution,set_resolution,true);
		addMember(l,"cullingMask",get_cullingMask,set_cullingMask,true);
		addMember(l,"clearFlags",get_clearFlags,set_clearFlags,true);
		addMember(l,"backgroundColor",get_backgroundColor,set_backgroundColor,true);
		addMember(l,"intensity",get_intensity,set_intensity,true);
		addMember(l,"blendDistance",get_blendDistance,set_blendDistance,true);
		addMember(l,"boxProjection",get_boxProjection,set_boxProjection,true);
		addMember(l,"bounds",get_bounds,null,true);
		addMember(l,"mode",get_mode,set_mode,true);
		addMember(l,"importance",get_importance,set_importance,true);
		addMember(l,"refreshMode",get_refreshMode,set_refreshMode,true);
		addMember(l,"timeSlicingMode",get_timeSlicingMode,set_timeSlicingMode,true);
		addMember(l,"bakedTexture",get_bakedTexture,set_bakedTexture,true);
		addMember(l,"customBakedTexture",get_customBakedTexture,set_customBakedTexture,true);
		addMember(l,"texture",get_texture,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ReflectionProbe),typeof(UnityEngine.Behaviour));
	}
}

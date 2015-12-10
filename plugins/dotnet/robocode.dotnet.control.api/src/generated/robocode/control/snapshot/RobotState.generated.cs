/**
 * Copyright (c) 2001-2016 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/epl-v10.html
 */
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.8000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace robocode.control.snapshot {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class RobotState : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_values0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_valueOf1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getValue2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isAlive3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toState4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isDead5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isHitRobot6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_isHitWall7;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_ACTIVE8;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_HIT_WALL9;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_HIT_ROBOT10;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_DEAD11;
        
        protected RobotState(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.snapshot.RobotState.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/RobotState;")]
        public static global::robocode.control.snapshot.RobotState ACTIVE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.RobotState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.RobotState.staticClass, global::robocode.control.snapshot.RobotState.j4n_ACTIVE8));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/RobotState;")]
        public static global::robocode.control.snapshot.RobotState HIT_WALL {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.RobotState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.RobotState.staticClass, global::robocode.control.snapshot.RobotState.j4n_HIT_WALL9));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/RobotState;")]
        public static global::robocode.control.snapshot.RobotState HIT_ROBOT {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.RobotState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.RobotState.staticClass, global::robocode.control.snapshot.RobotState.j4n_HIT_ROBOT10));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Lrobocode/control/snapshot/RobotState;")]
        public static global::robocode.control.snapshot.RobotState DEAD {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.RobotState>(@__env, @__env.GetStaticObjectFieldPtr(global::robocode.control.snapshot.RobotState.staticClass, global::robocode.control.snapshot.RobotState.j4n_DEAD11));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.snapshot.RobotState.staticClass = @__class;
            global::robocode.control.snapshot.RobotState.j4n_values0 = @__env.GetStaticMethodID(global::robocode.control.snapshot.RobotState.staticClass, "values", "()[Lrobocode/control/snapshot/RobotState;");
            global::robocode.control.snapshot.RobotState.j4n_valueOf1 = @__env.GetStaticMethodID(global::robocode.control.snapshot.RobotState.staticClass, "valueOf", "(Ljava/lang/String;)Lrobocode/control/snapshot/RobotState;");
            global::robocode.control.snapshot.RobotState.j4n_getValue2 = @__env.GetMethodID(global::robocode.control.snapshot.RobotState.staticClass, "getValue", "()I");
            global::robocode.control.snapshot.RobotState.j4n_isAlive3 = @__env.GetMethodID(global::robocode.control.snapshot.RobotState.staticClass, "isAlive", "()Z");
            global::robocode.control.snapshot.RobotState.j4n_toState4 = @__env.GetStaticMethodID(global::robocode.control.snapshot.RobotState.staticClass, "toState", "(I)Lrobocode/control/snapshot/RobotState;");
            global::robocode.control.snapshot.RobotState.j4n_isDead5 = @__env.GetMethodID(global::robocode.control.snapshot.RobotState.staticClass, "isDead", "()Z");
            global::robocode.control.snapshot.RobotState.j4n_isHitRobot6 = @__env.GetMethodID(global::robocode.control.snapshot.RobotState.staticClass, "isHitRobot", "()Z");
            global::robocode.control.snapshot.RobotState.j4n_isHitWall7 = @__env.GetMethodID(global::robocode.control.snapshot.RobotState.staticClass, "isHitWall", "()Z");
            global::robocode.control.snapshot.RobotState.j4n_ACTIVE8 = @__env.GetStaticFieldID(global::robocode.control.snapshot.RobotState.staticClass, "ACTIVE", "Lrobocode/control/snapshot/RobotState;");
            global::robocode.control.snapshot.RobotState.j4n_HIT_WALL9 = @__env.GetStaticFieldID(global::robocode.control.snapshot.RobotState.staticClass, "HIT_WALL", "Lrobocode/control/snapshot/RobotState;");
            global::robocode.control.snapshot.RobotState.j4n_HIT_ROBOT10 = @__env.GetStaticFieldID(global::robocode.control.snapshot.RobotState.staticClass, "HIT_ROBOT", "Lrobocode/control/snapshot/RobotState;");
            global::robocode.control.snapshot.RobotState.j4n_DEAD11 = @__env.GetStaticFieldID(global::robocode.control.snapshot.RobotState.staticClass, "DEAD", "Lrobocode/control/snapshot/RobotState;");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Lrobocode/control/snapshot/RobotState;")]
        public static robocode.control.snapshot.RobotState[] values() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<robocode.control.snapshot.RobotState[], global::robocode.control.snapshot.RobotState>(@__env, @__env.CallStaticObjectMethodPtr(global::robocode.control.snapshot.RobotState.staticClass, global::robocode.control.snapshot.RobotState.j4n_values0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Lrobocode/control/snapshot/RobotState;")]
        public static global::robocode.control.snapshot.RobotState valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.RobotState>(@__env, @__env.CallStaticObjectMethodPtr(global::robocode.control.snapshot.RobotState.staticClass, global::robocode.control.snapshot.RobotState.j4n_valueOf1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((int)(@__env.CallIntMethod(this, global::robocode.control.snapshot.RobotState.j4n_getValue2)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isAlive() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::robocode.control.snapshot.RobotState.j4n_isAlive3)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Lrobocode/control/snapshot/RobotState;")]
        public static global::robocode.control.snapshot.RobotState toState(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::robocode.control.snapshot.RobotState>(@__env, @__env.CallStaticObjectMethodPtr(global::robocode.control.snapshot.RobotState.staticClass, global::robocode.control.snapshot.RobotState.j4n_toState4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isDead() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::robocode.control.snapshot.RobotState.j4n_isDead5)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isHitRobot() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::robocode.control.snapshot.RobotState.j4n_isHitRobot6)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isHitWall() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::robocode.control.snapshot.RobotState.j4n_isHitWall7)));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.snapshot.RobotState(@__env);
            }
        }
    }
    #endregion
}

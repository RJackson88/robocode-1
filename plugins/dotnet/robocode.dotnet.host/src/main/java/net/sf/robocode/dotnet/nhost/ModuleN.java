/**
 * Copyright (c) 2001-2016 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/epl-v10.html
 */
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package net.sf.robocode.dotnet.nhost;

@net.sf.jni4net.attributes.ClrType
public class ModuleN extends system.Object {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected ModuleN(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("()V")
    public ModuleN() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        net.sf.robocode.dotnet.nhost.ModuleN.__ctorModuleN0(this);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    private native static void __ctorModuleN0(net.sf.jni4net.inj.IClrProxy thiz);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native static void InitN();
    
    public static system.Type typeof() {
        return net.sf.robocode.dotnet.nhost.ModuleN.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        net.sf.robocode.dotnet.nhost.ModuleN.staticType = staticType;
    }
    //</generated-proxy>
}

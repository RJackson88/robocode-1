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

package net.sf.robocode.host.proxies;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class IHostingRobotProxy_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return net.sf.robocode.host.proxies.IHostingRobotProxy_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        net.sf.robocode.host.proxies.IHostingRobotProxy_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __IHostingRobotProxy extends system.Object implements net.sf.robocode.host.proxies.IHostingRobotProxy {
    
    protected __IHostingRobotProxy(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void cleanup();
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;Ljava/lang/Object;)V")
    public native void startRound(net.sf.robocode.peer.ExecCommands par0, robocode.RobotStatus par1);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void forceStopThread();
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void waitForStopThread();
}
//</generated-proxy>

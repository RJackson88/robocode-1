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

package robocode.control.snapshot;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class IRobotSnapshot_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return robocode.control.snapshot.IRobotSnapshot_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        robocode.control.snapshot.IRobotSnapshot_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __IRobotSnapshot extends system.Object implements robocode.control.snapshot.IRobotSnapshot {
    
    protected __IRobotSnapshot(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getName();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lrobocode/control/snapshot/RobotState;")
    public native robocode.control.snapshot.RobotState getState();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getTeamName();
    
    @net.sf.jni4net.attributes.ClrMethod("()D")
    public native double getX();
    
    @net.sf.jni4net.attributes.ClrMethod("()D")
    public native double getY();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getShortName();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getVeryShortName();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getRobotIndex();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getTeamIndex();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getContestantIndex();
    
    @net.sf.jni4net.attributes.ClrMethod("()D")
    public native double getEnergy();
    
    @net.sf.jni4net.attributes.ClrMethod("()D")
    public native double getVelocity();
    
    @net.sf.jni4net.attributes.ClrMethod("()D")
    public native double getBodyHeading();
    
    @net.sf.jni4net.attributes.ClrMethod("()D")
    public native double getGunHeading();
    
    @net.sf.jni4net.attributes.ClrMethod("()D")
    public native double getRadarHeading();
    
    @net.sf.jni4net.attributes.ClrMethod("()D")
    public native double getGunHeat();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getBodyColor();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getGunColor();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getRadarColor();
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native int getScanColor();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isDroid();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSentryRobot();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isPaintRobot();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isPaintEnabled();
    
    @net.sf.jni4net.attributes.ClrMethod("()Z")
    public native boolean isSGPaintEnabled();
    
    @net.sf.jni4net.attributes.ClrMethod("()[Lrobocode/control/snapshot/IDebugProperty;")
    public native robocode.control.snapshot.IDebugProperty[] getDebugProperties();
    
    @net.sf.jni4net.attributes.ClrMethod("()Ljava/lang/String;")
    public native java.lang.String getOutputStreamSnapshot();
    
    @net.sf.jni4net.attributes.ClrMethod("()Lrobocode/control/snapshot/IScoreSnapshot;")
    public native robocode.control.snapshot.IScoreSnapshot getScoreSnapshot();
}
//</generated-proxy>

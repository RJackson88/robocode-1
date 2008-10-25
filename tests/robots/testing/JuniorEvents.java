/*******************************************************************************
 * Copyright (c) 2001, 2008 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Common Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/cpl-v10.html
 *
 * Contributors:
 *     Pavel Savara
 *     - Initial implementation
 *******************************************************************************/
package testing;


import robocode.*;
import robocode.util.Utils;
import robocode.robotinterfaces.IJuniorRobot;
import robocode.robotinterfaces.IBasicEvents;
import robocode.robotinterfaces.peer.IBasicRobotPeer;

import java.io.PrintStream;
import java.util.Hashtable;
import java.util.Map;


/**
 * @author Pavel Savara (original)
 */
public class JuniorEvents implements IJuniorRobot, IBasicEvents, Runnable {

	IBasicRobotPeer peer;
	PrintStream out;
	Hashtable<String, Integer> counts = new Hashtable<String, Integer>();

	public void run() {
		// noinspection InfiniteLoopStatement
		while (true) {
			peer.move(100); // Move ahead 100
			peer.turnGun(Math.PI * 2); // Spin gun around
			peer.move(-100); // Move back 100
			peer.turnGun(Math.PI * 2); // Spin gun around
		}
	}

	public Runnable getRobotRunnable() {
		return this;
	}

	public IBasicEvents getBasicEventListener() {
		return this;
	}

	public void setPeer(IBasicRobotPeer peer) {
		this.peer = peer;
	}

	public void setOut(PrintStream out) {
		this.out = out;
	}

	public void onStatus(StatusEvent event) {
		count(event);
	}

	public void onBulletHit(BulletHitEvent event) {
		count(event);
	}

	public void onBulletHitBullet(BulletHitBulletEvent event) {
		count(event);
	}

	public void onBulletMissed(BulletMissedEvent event) {
		count(event);
	}

	public void onDeath(DeathEvent event) {
		count(event);
	}

	public void onHitByBullet(HitByBulletEvent event) {
		count(event);
	}

	public void onHitRobot(HitRobotEvent event) {
		count(event);
	}

	public void onHitWall(HitWallEvent event) {
		count(event);
	}

	public void onRobotDeath(RobotDeathEvent event) {
		count(event);
	}

	public void onWin(WinEvent event) {
		count(event);
		for (Map.Entry<String, Integer> s : counts.entrySet()) {
			out.println(s.getKey() + " " + s.getValue());
		}
	}

	public void onScannedRobot(ScannedRobotEvent event) {
		count(event);

		// Turn gun to point at the scanned robot
		peer.turnGun(Utils.normalAbsoluteAngle(peer.getBodyHeading() + event.getBearingRadians() - peer.getGunHeading())); //

		// Fire!
		peer.fire(
				1);
	}

	private void count(Event event) {
		final String name = event.getClass().getName();
		Integer curr = counts.get(name);

		if (curr == null) {
			curr = 0;
		}
		counts.put(name, curr + 1);
		// out.println(event.getTime() + name);
	}
}

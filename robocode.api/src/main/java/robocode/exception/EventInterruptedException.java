/**
 * Copyright (c) 2001-2016 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/epl-v10.html
 */
package robocode.exception;


/**
 * @author Mathew A. Nelson (original)
 */
public class EventInterruptedException extends Error { // Must be an Error!
	private static final long serialVersionUID = 1L;

	private int priority = Integer.MIN_VALUE;

	public EventInterruptedException(int priority) {
		this.priority = priority;
	}

	public int getPriority() {
		return priority;
	}
}

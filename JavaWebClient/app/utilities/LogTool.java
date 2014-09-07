package utilities;

import java.util.Objects;

import play.Logger;

/**
 * The Class Logger.
 * This class handles all the logging.
 * All logging in the application goes through this for more consistency.
 * This allows easy on/off of logging.
 * This class also handles writing logs and files to disk. Some are depreciated.
 */
public class LogTool {
	
	/**
	 * Log data to console.
	 *
	 * @param heading the heading of the log data
	 * @param data the data of the log
	 */
	public static void log(String heading, Object data) {
		Logger.info(heading.toUpperCase(), data);
		//System.out.println(heading.toUpperCase() + ":\n\t" + data);
	}
	
	/**
	 * Log data to console.
	 *
	 * @param heading the text to log
	 */
	public static void log(String heading) {
		Objects.requireNonNull(heading);
		Logger.info(heading.toUpperCase());
		//System.out.println(heading.toUpperCase() + "...");
	}
	
	/**
	 * Log data to console.
	 *
	 * @param obj the object
	 */
	public static void log(Object obj) {
		Logger.info(obj.toString());
	}
	
	public static void error(String text) {
		Logger.error(text);
	}
	
	public static void error(String text, Object o) {
		Logger.error(text, o);
	}
	
	public static void error(String text, Throwable t) {
		Logger.error(text, t);
	}
	
	public static void trace(String text) {
		Logger.trace(text);
	}
	
	public static void trace(String text, Object data) {
		Logger.trace(text, data);
	}
	
	public static void traceC(Class<?> obj, String text, Object data) {
		Logger.ALogger logger = Logger.of(obj);
		logger.trace(text, data);
	}
	
	public static void traceC(Class<?> obj, String text) {
		Logger.ALogger logger = Logger.of(obj);
		logger.trace(text);
	}
	
	public static void warnC(Class<?> obj, String text, Object data) {
		Logger.ALogger logger = Logger.of(obj);
		logger.warn(text, data);
	}
	
	public static void errorC(Class<?> obj, String text, Object data) {
		Logger.ALogger logger = Logger.of(obj);
		logger.error(text, data);
	}
}


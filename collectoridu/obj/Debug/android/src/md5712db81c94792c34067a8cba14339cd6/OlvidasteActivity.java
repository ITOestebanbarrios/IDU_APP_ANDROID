package md5712db81c94792c34067a8cba14339cd6;


public class OlvidasteActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("collectoridu.Controllers.OlvidasteActivity, collectoridu", OlvidasteActivity.class, __md_methods);
	}


	public OlvidasteActivity ()
	{
		super ();
		if (getClass () == OlvidasteActivity.class)
			mono.android.TypeManager.Activate ("collectoridu.Controllers.OlvidasteActivity, collectoridu", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

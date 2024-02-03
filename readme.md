Repro for https://github.com/PrismLibrary/Prism/issues/3063

On iOS tap at "Click me" and get 
```console
Unhandled Exception:
System.InvalidOperationException: Operation is not valid due to the current state of the object.
at Microsoft.Maui.Controls.Binding.ApplyRelativeSourceBinding(BindableObject targetObject, BindableProperty targetProperty, SetterSpecificity specificity)
at ObjCRuntime.Runtime.ThrowException(IntPtr gchandle) in /Users/builder/azdo/_work/1/s/xamarin-macios/src/ObjCRuntime/Runtime.cs:line 2594
at UIKit.UIApplication.UIApplicationMain(Int32 argc, String[] argv, IntPtr principalClassName, IntPtr delegateClassName) in /Users/builder/azdo/_work/1/s/xamarin-macios/src/UIKit/UIApplication.cs:line 60
at UIKit.UIApplication.Main(String[] args, Type principalClass, Type delegateClass) in /Users/builder/azdo/_work/1/s/xamarin-macios/src/UIKit/UIApplication.cs:line 94
at prism_relative_binding.Program.Main(String[] args) in /Users/a/prism-relative-binding/Platforms/iOS/Program.cs:line 13
2024-02-03 09:43:04.918110+0100 prism-relative-binding[5671:80165] Unhandled managed exception: Operation is not valid due to the current state of the object. (System.InvalidOperationException)
at Microsoft.Maui.Controls.Binding.ApplyRelativeSourceBinding(BindableObject targetObject, BindableProperty targetProperty, SetterSpecificity specificity)
at ObjCRuntime.Runtime.ThrowException(IntPtr gchandle) in /Users/builder/azdo/_work/1/s/xamarin-macios/src/ObjCRuntime/Runtime.cs:line 2594
at UIKit.UIApplication.UIApplicationMain(Int32 argc, String[] argv, IntPtr principalClassName, IntPtr delegateClassName) in /Users/builder/azdo/_work/1/s/xamarin-macios/src/UIKit/UIApplication.cs:line 60
at UIKit.UIApplication.Main(String[] args, Type principalClass, Type delegateClass) in /Users/builder/azdo/_work/1/s/xamarin-macios/src/UIKit/UIApplication.cs:line 94
at prism_relative_binding.Program.Main(String[] args) in /Users/a/prism-relative-binding/Platforms/iOS/Program.cs:line 13

=================================================================
Native Crash Reporting
=================================================================
Got a SIGABRT while executing native code. This usually indicates
a fatal error in the mono runtime or one of the native libraries
used by your application.
=================================================================

=================================================================
Native stacktrace:
=================================================================
0x10f77e485 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : mono_dump_native_crash_info
0x10f71ce1e - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : mono_handle_native_crash
0x10fa75b58 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : sigabrt_signal_handler.cold.1
0x10f77ddc0 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : mono_runtime_setup_stat_profiler
0x10ec505ed - /usr/lib/system/libsystem_platform.dylib : _sigtramp
0x0 - Unknown
0x7ff80014cd30 - /Library/Developer/CoreSimulator/Volumes/iOS_21C62/Library/Developer/CoreSimulator/Profiles/Runtimes/iOS 17.2.simruntime/Contents/Resources/RuntimeRoot/usr/lib/system/libsystem_c.dylib : abort
0x10f0260e7 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libxamarin-dotnet-debug.dylib : xamarin_unhandled_exception_handler
0x10f81c184 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : mono_invoke_unhandled_exception_hook
0x10f71ca1f - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : mono_handle_exception_internal
0x10f71aa65 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : mono_handle_exception
0x10f7928b9 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : interp_throw
0x10f790a0c - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : interp_throw_ex_general
0x10f78ac35 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : mono_interp_exec_method
0x10f77fd13 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : interp_runtime_invoke
0x10f866748 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : mono_runtime_invoke_checked
0x10f86e09b - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : mono_runtime_exec_main_checked
0x10f6d2482 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libmonosgen-2.0.dylib : mono_jit_exec
0x10f039bea - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/libxamarin-dotnet-debug.dylib : xamarin_main
0x10df12a04 - /Users/a/Library/Developer/CoreSimulator/Devices/33065ED0-FF7C-480B-A05E-A3AE4107413D/data/Containers/Bundle/Application/87F0192C-F18B-42B9-9A8A-010EF89185D7/prism-relative-binding.app/prism-relative-binding : main
0x10e5723e0 - Unknown
0x114ebc41f - Unknown

=================================================================
Basic Fault Address Reporting
=================================================================
Memory around native instruction pointer (0x10f21a1e2):0x10f21a1d2  ff ff c3 90 90 90 b8 48 01 00 02 49 89 ca 0f 05  .......H...I....
0x10f21a1e2  73 08 48 89 c7 e9 df 9a ff ff c3 90 90 90 b8 53  s.H............S
0x10f21a1f2  00 00 02 49 89 ca 0f 05 73 08 48 89 c7 e9 c7 9a  ...I....s.H.....
0x10f21a202  ff ff c3 90 90 90 b8 83 01 00 02 49 89 ca 0f 05  ...........I....

=================================================================
Managed Stacktrace:
=================================================================
=================================================================
```
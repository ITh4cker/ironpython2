/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Microsoft Public License. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Microsoft Public License, please send an email to 
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Microsoft Public License.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System;
using System.Collections;
using IronPython.Runtime;

namespace IronPython.Compiler {
    #region Generated Python Call Targets

    // *** BEGIN GENERATED CODE ***
    // generated by function: call_targets from: generate_calls.py

    public delegate object CallTarget0(PythonFunction function);
    public delegate object CallTarget1(PythonFunction function, object arg0);
    public delegate object CallTarget2(PythonFunction function, object arg0, object arg1);
    public delegate object CallTarget3(PythonFunction function, object arg0, object arg1, object arg2);
    public delegate object CallTarget4(PythonFunction function, object arg0, object arg1, object arg2, object arg3);
    public delegate object CallTarget5(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4);
    public delegate object CallTarget6(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5);
    public delegate object CallTarget7(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6);
    public delegate object CallTarget8(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7);
    public delegate object CallTarget9(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8);
    public delegate object CallTarget10(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9);
    public delegate object CallTarget11(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10);
    public delegate object CallTarget12(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11);
    public delegate object CallTarget13(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12);
    public delegate object CallTarget14(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13);
    public delegate object CallTarget15(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14);
    public delegate object CallTarget16(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15);

    // *** END GENERATED CODE ***

    #endregion

    public delegate object CallTargetN(PythonFunction function, params object[] args);

    #region Generated Python Generator Targets

    // *** BEGIN GENERATED CODE ***
    // generated by function: generator_targets from: generate_calls.py

    public delegate IEnumerator GeneratorTarget0(PythonGenerator generator);
    public delegate IEnumerator GeneratorTarget1(PythonGenerator generator, object arg0);
    public delegate IEnumerator GeneratorTarget2(PythonGenerator generator, object arg0, object arg1);
    public delegate IEnumerator GeneratorTarget3(PythonGenerator generator, object arg0, object arg1, object arg2);
    public delegate IEnumerator GeneratorTarget4(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3);
    public delegate IEnumerator GeneratorTarget5(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4);
    public delegate IEnumerator GeneratorTarget6(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5);
    public delegate IEnumerator GeneratorTarget7(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6);
    public delegate IEnumerator GeneratorTarget8(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7);
    public delegate IEnumerator GeneratorTarget9(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8);
    public delegate IEnumerator GeneratorTarget10(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9);
    public delegate IEnumerator GeneratorTarget11(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10);
    public delegate IEnumerator GeneratorTarget12(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11);
    public delegate IEnumerator GeneratorTarget13(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12);
    public delegate IEnumerator GeneratorTarget14(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13);
    public delegate IEnumerator GeneratorTarget15(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14);
    public delegate IEnumerator GeneratorTarget16(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15);

    // *** END GENERATED CODE ***

    #endregion

    public delegate IEnumerator GeneratorTargetN(PythonGenerator generator, params object[] args);

    
    internal static class PythonCallTargets {
        public static object OriginalCallTargetN(PythonFunction function, params object[] args) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTargetN)function.Target)(function, args);
        }

        public static IEnumerator OriginalGeneratorTargetN(PythonGenerator generator, params object[] args) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTargetN)generator.Function.Target)(generator, args);
        }

        #region Generated Python Lazy Call Targets

        // *** BEGIN GENERATED CODE ***
        // generated by function: gen_lazy_call_targets from: generate_calls.py

        public static object OriginalCallTarget0(PythonFunction function) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget0)function.Target)(function);
        }

        public static IEnumerator OriginalGeneratorTarget0(PythonGenerator generator) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget0)generator.Function.Target)(generator);
        }

        public static object OriginalCallTarget1(PythonFunction function, object arg0) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget1)function.Target)(function, arg0);
        }

        public static IEnumerator OriginalGeneratorTarget1(PythonGenerator generator, object arg0) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget1)generator.Function.Target)(generator, arg0);
        }

        public static object OriginalCallTarget2(PythonFunction function, object arg0, object arg1) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget2)function.Target)(function, arg0, arg1);
        }

        public static IEnumerator OriginalGeneratorTarget2(PythonGenerator generator, object arg0, object arg1) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget2)generator.Function.Target)(generator, arg0, arg1);
        }

        public static object OriginalCallTarget3(PythonFunction function, object arg0, object arg1, object arg2) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget3)function.Target)(function, arg0, arg1, arg2);
        }

        public static IEnumerator OriginalGeneratorTarget3(PythonGenerator generator, object arg0, object arg1, object arg2) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget3)generator.Function.Target)(generator, arg0, arg1, arg2);
        }

        public static object OriginalCallTarget4(PythonFunction function, object arg0, object arg1, object arg2, object arg3) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget4)function.Target)(function, arg0, arg1, arg2, arg3);
        }

        public static IEnumerator OriginalGeneratorTarget4(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget4)generator.Function.Target)(generator, arg0, arg1, arg2, arg3);
        }

        public static object OriginalCallTarget5(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget5)function.Target)(function, arg0, arg1, arg2, arg3, arg4);
        }

        public static IEnumerator OriginalGeneratorTarget5(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget5)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4);
        }

        public static object OriginalCallTarget6(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget6)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5);
        }

        public static IEnumerator OriginalGeneratorTarget6(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget6)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5);
        }

        public static object OriginalCallTarget7(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget7)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static IEnumerator OriginalGeneratorTarget7(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget7)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static object OriginalCallTarget8(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget8)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static IEnumerator OriginalGeneratorTarget8(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget8)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static object OriginalCallTarget9(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget9)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static IEnumerator OriginalGeneratorTarget9(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget9)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static object OriginalCallTarget10(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget10)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static IEnumerator OriginalGeneratorTarget10(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget10)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static object OriginalCallTarget11(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget11)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static IEnumerator OriginalGeneratorTarget11(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget11)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static object OriginalCallTarget12(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget12)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static IEnumerator OriginalGeneratorTarget12(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget12)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static object OriginalCallTarget13(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget13)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static IEnumerator OriginalGeneratorTarget13(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget13)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static object OriginalCallTarget14(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget14)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static IEnumerator OriginalGeneratorTarget14(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget14)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static object OriginalCallTarget15(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget15)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static IEnumerator OriginalGeneratorTarget15(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget15)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static object OriginalCallTarget16(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15) {
            function.Target = function.func_code.Code.Compile();
            return ((CallTarget16)function.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static IEnumerator OriginalGeneratorTarget16(PythonGenerator generator, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14, object arg15) {
            generator.Function.Target = generator.Function.func_code.Code.Compile();
            return ((GeneratorTarget16)generator.Function.Target)(generator, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }


        // *** END GENERATED CODE ***

        #endregion

        public const int MaxArgs = 16;
        internal static Type GetPythonTargetType(bool wrapper, int parameters, out Delegate originalTarget) {
            if (!wrapper) {
                switch (parameters) {
                    #region Generated Python Call Target Switch

                    // *** BEGIN GENERATED CODE ***
                    // generated by function: gen_python_switch from: generate_calls.py

                    case 0: 
                        originalTarget = (CallTarget0)OriginalCallTarget0;
                        return typeof(CallTarget0);
                    case 1: 
                        originalTarget = (CallTarget1)OriginalCallTarget1;
                        return typeof(CallTarget1);
                    case 2: 
                        originalTarget = (CallTarget2)OriginalCallTarget2;
                        return typeof(CallTarget2);
                    case 3: 
                        originalTarget = (CallTarget3)OriginalCallTarget3;
                        return typeof(CallTarget3);
                    case 4: 
                        originalTarget = (CallTarget4)OriginalCallTarget4;
                        return typeof(CallTarget4);
                    case 5: 
                        originalTarget = (CallTarget5)OriginalCallTarget5;
                        return typeof(CallTarget5);
                    case 6: 
                        originalTarget = (CallTarget6)OriginalCallTarget6;
                        return typeof(CallTarget6);
                    case 7: 
                        originalTarget = (CallTarget7)OriginalCallTarget7;
                        return typeof(CallTarget7);
                    case 8: 
                        originalTarget = (CallTarget8)OriginalCallTarget8;
                        return typeof(CallTarget8);
                    case 9: 
                        originalTarget = (CallTarget9)OriginalCallTarget9;
                        return typeof(CallTarget9);
                    case 10: 
                        originalTarget = (CallTarget10)OriginalCallTarget10;
                        return typeof(CallTarget10);
                    case 11: 
                        originalTarget = (CallTarget11)OriginalCallTarget11;
                        return typeof(CallTarget11);
                    case 12: 
                        originalTarget = (CallTarget12)OriginalCallTarget12;
                        return typeof(CallTarget12);
                    case 13: 
                        originalTarget = (CallTarget13)OriginalCallTarget13;
                        return typeof(CallTarget13);
                    case 14: 
                        originalTarget = (CallTarget14)OriginalCallTarget14;
                        return typeof(CallTarget14);
                    case 15: 
                        originalTarget = (CallTarget15)OriginalCallTarget15;
                        return typeof(CallTarget15);
                    case 16: 
                        originalTarget = (CallTarget16)OriginalCallTarget16;
                        return typeof(CallTarget16);

                    // *** END GENERATED CODE ***

                    #endregion
                }
            }

            originalTarget = (CallTargetN)OriginalCallTargetN; 
            return typeof(CallTargetN);
        }

        internal static Type GetGeneratorTargetType(bool wrapper, int parameters, out Delegate originalTarget) {
            if (!wrapper) {
                switch (parameters) {
                    #region Generated Python Generator Target Switch

                    // *** BEGIN GENERATED CODE ***
                    // generated by function: gen_python_generator_switch from: generate_calls.py

                    case 0: 
                        originalTarget = (GeneratorTarget0)OriginalGeneratorTarget0;
                        return typeof(GeneratorTarget0);
                    case 1: 
                        originalTarget = (GeneratorTarget1)OriginalGeneratorTarget1;
                        return typeof(GeneratorTarget1);
                    case 2: 
                        originalTarget = (GeneratorTarget2)OriginalGeneratorTarget2;
                        return typeof(GeneratorTarget2);
                    case 3: 
                        originalTarget = (GeneratorTarget3)OriginalGeneratorTarget3;
                        return typeof(GeneratorTarget3);
                    case 4: 
                        originalTarget = (GeneratorTarget4)OriginalGeneratorTarget4;
                        return typeof(GeneratorTarget4);
                    case 5: 
                        originalTarget = (GeneratorTarget5)OriginalGeneratorTarget5;
                        return typeof(GeneratorTarget5);
                    case 6: 
                        originalTarget = (GeneratorTarget6)OriginalGeneratorTarget6;
                        return typeof(GeneratorTarget6);
                    case 7: 
                        originalTarget = (GeneratorTarget7)OriginalGeneratorTarget7;
                        return typeof(GeneratorTarget7);
                    case 8: 
                        originalTarget = (GeneratorTarget8)OriginalGeneratorTarget8;
                        return typeof(GeneratorTarget8);
                    case 9: 
                        originalTarget = (GeneratorTarget9)OriginalGeneratorTarget9;
                        return typeof(GeneratorTarget9);
                    case 10: 
                        originalTarget = (GeneratorTarget10)OriginalGeneratorTarget10;
                        return typeof(GeneratorTarget10);
                    case 11: 
                        originalTarget = (GeneratorTarget11)OriginalGeneratorTarget11;
                        return typeof(GeneratorTarget11);
                    case 12: 
                        originalTarget = (GeneratorTarget12)OriginalGeneratorTarget12;
                        return typeof(GeneratorTarget12);
                    case 13: 
                        originalTarget = (GeneratorTarget13)OriginalGeneratorTarget13;
                        return typeof(GeneratorTarget13);
                    case 14: 
                        originalTarget = (GeneratorTarget14)OriginalGeneratorTarget14;
                        return typeof(GeneratorTarget14);
                    case 15: 
                        originalTarget = (GeneratorTarget15)OriginalGeneratorTarget15;
                        return typeof(GeneratorTarget15);
                    case 16: 
                        originalTarget = (GeneratorTarget16)OriginalGeneratorTarget16;
                        return typeof(GeneratorTarget16);

                    // *** END GENERATED CODE ***

                    #endregion
                }
            }

            originalTarget = (GeneratorTargetN)OriginalGeneratorTargetN;
            return typeof(GeneratorTargetN);
        }
    }
}
// #Regression #Conformance #PatternMatching #ActivePatterns 
// Verify error when defining an Active Pattern with more than twenty 'values'
// This is regression test for FSHARP1.0:3562
//<Expects id="FS0265" span="(6,155)" status="error">Active patterns cannot return more than 20 possibilities$</Expects>

let (|One|Two|Three|Four|Five|Six|Seven|Eight|Nine|Ten|Eleven|Twelve|Thirteen|Fourteen|Fifteen|Sixteen|Seventeen|Eighteen|Nineteen|Twenty|TwentyOne|) x = One


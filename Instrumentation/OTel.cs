using OpenTelemetry.Trace;

namespace Instrumentation;

public static class OTel
{
    private static readonly Tracer _tracer = TracerProvider.Default.GetTracer("AdventOfCode");

    public static TelemetrySpan StartActiveSpan(string name)
        => _tracer.StartActiveSpan(name);
}
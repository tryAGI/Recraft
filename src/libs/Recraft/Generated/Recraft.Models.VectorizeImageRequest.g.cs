#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VectorizeImageRequest : global::System.IEquatable<VectorizeImageRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.ProcessImageRequest? Process { get; init; }
#else
        public global::Recraft.ProcessImageRequest? Process { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Process))]
#endif
        public bool IsProcess => Process != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.VectorizeImageRequestVariant2? VectorizeImageRequestVariant2 { get; init; }
#else
        public global::Recraft.VectorizeImageRequestVariant2? VectorizeImageRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorizeImageRequestVariant2))]
#endif
        public bool IsVectorizeImageRequestVariant2 => VectorizeImageRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorizeImageRequest(global::Recraft.ProcessImageRequest value) => new VectorizeImageRequest((global::Recraft.ProcessImageRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.ProcessImageRequest?(VectorizeImageRequest @this) => @this.Process;

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageRequest(global::Recraft.ProcessImageRequest? value)
        {
            Process = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorizeImageRequest(global::Recraft.VectorizeImageRequestVariant2 value) => new VectorizeImageRequest((global::Recraft.VectorizeImageRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.VectorizeImageRequestVariant2?(VectorizeImageRequest @this) => @this.VectorizeImageRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageRequest(global::Recraft.VectorizeImageRequestVariant2? value)
        {
            VectorizeImageRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageRequest(
            global::Recraft.ProcessImageRequest? process,
            global::Recraft.VectorizeImageRequestVariant2? vectorizeImageRequestVariant2
            )
        {
            Process = process;
            VectorizeImageRequestVariant2 = vectorizeImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorizeImageRequestVariant2 as object ??
            Process as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Process?.ToString() ??
            VectorizeImageRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProcess && IsVectorizeImageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.ProcessImageRequest?, TResult>? process = null,
            global::System.Func<global::Recraft.VectorizeImageRequestVariant2?, TResult>? vectorizeImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProcess && process != null)
            {
                return process(Process!);
            }
            else if (IsVectorizeImageRequestVariant2 && vectorizeImageRequestVariant2 != null)
            {
                return vectorizeImageRequestVariant2(VectorizeImageRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.ProcessImageRequest?>? process = null,
            global::System.Action<global::Recraft.VectorizeImageRequestVariant2?>? vectorizeImageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProcess)
            {
                process?.Invoke(Process!);
            }
            else if (IsVectorizeImageRequestVariant2)
            {
                vectorizeImageRequestVariant2?.Invoke(VectorizeImageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Process,
                typeof(global::Recraft.ProcessImageRequest),
                VectorizeImageRequestVariant2,
                typeof(global::Recraft.VectorizeImageRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(VectorizeImageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.ProcessImageRequest?>.Default.Equals(Process, other.Process) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.VectorizeImageRequestVariant2?>.Default.Equals(VectorizeImageRequestVariant2, other.VectorizeImageRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorizeImageRequest obj1, VectorizeImageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorizeImageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorizeImageRequest obj1, VectorizeImageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorizeImageRequest o && Equals(o);
        }
    }
}
